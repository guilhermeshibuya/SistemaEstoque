using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Sistema.Modelo;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace Sistema
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        SqlCommand objCommand = null;

        public void ListaGrid()
        {
            string strSql = "select * from tb_categoria order by desc_categoria";
            Conexao con = new Conexao();
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                DgvCategoria.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            ListaGrid();
            DgvCategoria.Columns[0].HeaderText = "Código";
            DgvCategoria.Columns[1].HeaderText = "Descrição";
            DgvCategoria.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvCategoria.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvCategoria.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvCategoria.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtCategoria.Text) && TxtCategoria.Text.Length > 1)
            {
                Categoria categoria = new Categoria(TxtCategoria.Text);
                string mensagem = categoria.Cadastrar();

                if (categoria.Tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaGrid();
                }
                else
                {
                    MessageBox.Show(categoria.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo vazio ou inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TxtCategoria.Text = string.Empty;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int categoriaId = int.Parse(DgvCategoria.Rows[DgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());

            Categoria categoria = new Categoria();
            string mensagem = categoria.Deletar(categoriaId);

            if (categoria.Tem)
            {
                MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaGrid();
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!TxtCategoria.Text.Equals(DgvCategoria.Rows[DgvCategoria.CurrentRow.Index].Cells[1].Value.ToString()))
            {
                if (!String.IsNullOrWhiteSpace(TxtCategoria.Text) && TxtCategoria.Text.Length > 1)
                {
                    int categoriaId = int.Parse(DgvCategoria.Rows[DgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());

                    Categoria cat = new Categoria(categoriaId, TxtCategoria.Text);
                    string mensagem = cat.Alterar();

                    if (cat.Tem)
                    {
                        MessageBox.Show(mensagem, "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListaGrid();
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campo vazio ou inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum dado foi alterado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string descricao = DgvCategoria.Rows[DgvCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            TxtCategoria.Text = descricao;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtCategoria.Text = string.Empty;
            DgvCategoria.CurrentCell = null;
            DgvCategoria.ClearSelection();
            DgvCategoria.CurrentCell = null;
        }
    }
}