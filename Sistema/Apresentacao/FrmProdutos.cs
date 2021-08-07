using System;
using Sistema.Modelo;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sistema.DAL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            ListaCombo();
            ListaGrid();
            DgvProdutos.Columns[0].HeaderText = "Código";
            DgvProdutos.Columns[1].HeaderText = "Categoria";
            DgvProdutos.Columns[2].HeaderText = "Descrição";
            DgvProdutos.Columns[3].HeaderText = "Valor";
            DgvProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto(txt_nome.Text, Convert.ToDouble(txt_valor.Text), Convert.ToInt32(cmb_Categoria.SelectedValue));
            string mensagem = prod.Cadastrar();
            if (prod.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaGrid();
            }
            else
            {
                MessageBox.Show(prod.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_nome.Text = string.Empty;
            txt_valor.Text = string.Empty;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Conexao con = new Conexao();
        public void ListaCombo()
        {
            try
            {
                con.Conectar();
                string strSql = "select id_categoria, desc_categoria from tb_categoria order by desc_categoria";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                
                this.cmb_Categoria.DataSource = dt;
                this.cmb_Categoria.DisplayMember = "desc_categoria";
                this.cmb_Categoria.ValueMember = "id_categoria";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListaGrid()
        {
            string strSql = "select * from tb_produto";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                DgvProdutos.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }
    }
}
