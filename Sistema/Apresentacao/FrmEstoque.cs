using System;
using Sistema.Modelo;
using Sistema.DAL;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Apresentacao
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            Lista();
            ListaCombo();
            dgvEstoque.Columns[0].HeaderText = "Código";
            dgvEstoque.Columns[1].HeaderText = "Código \nProduto";
            dgvEstoque.Columns[2].HeaderText = "Quantidade";
            dgvEstoque.Columns[3].HeaderText = "Descrição";
            dgvEstoque.Columns[4].HeaderText = "Valor";

            dgvEstoque.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEstoque.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEstoque.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEstoque.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEstoque.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvEstoque.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEstoque.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int resultado;
            bool verificar = Int32.TryParse(txtCodigo.Text, out resultado);

            if (!String.IsNullOrWhiteSpace(txtCodigo.Text) && verificar && resultado > 0)
            {
                Conexao con = new Conexao();
                string strSql = "select cod_estoque, fk_cod_produto, quantidade, prod.desc_produto, prod.valor " +
                    "from tb_estoque est " +
                    "join tb_produto prod " +
                    "on est.fk_cod_produto = prod.cod_produto where cod_estoque = '" + resultado + "'";
                SqlCommand objCommand = null;
                objCommand = new SqlCommand(strSql, con.Conectar());

                try
                {
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                    DataTable dt = new DataTable();
                    objAdp.Fill(dt);

                    dgvEstoque.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Desconectar();
            }
            else
            {
                MessageBox.Show("Insira um código válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarCategoria();
        }

        private void ListaCombo()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select id_categoria, desc_categoria from tb_categoria order by desc_categoria";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbCategoria.DataSource = dt;
                cmbCategoria.ValueMember = "id_categoria";
                cmbCategoria.DisplayMember = "desc_categoria";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista()
        {
            Conexao con = new Conexao();
            string strSql = "select cod_estoque, fk_cod_produto, quantidade, prod.desc_produto, prod.valor " +
                "from tb_estoque est " +
                "join tb_produto prod " +
                "on est.fk_cod_produto = prod.cod_produto";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dgvEstoque.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void FiltrarCategoria()
        {
            Conexao con = new Conexao();
            string strSql = "select cod_estoque, fk_cod_produto, quantidade, prod.desc_produto, prod.valor " +
                "from tb_estoque est " +
                "join tb_produto prod " +
                "on est.fk_cod_produto = prod.cod_produto where prod.fk_cod_categoria = '"+ cmbCategoria.SelectedValue + "' order by prod.desc_produto";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dgvEstoque.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void BuscaCodigo()
        {
            Conexao con = new Conexao();
            string strSql = "";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dgvEstoque.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            Lista();
            dgvEstoque.ClearSelection();
            dgvEstoque.CurrentCell = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
