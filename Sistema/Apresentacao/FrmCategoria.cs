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
            string strSql = "select * from tb_categoria";
            Conexao con = new Conexao();
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);
                
                DgvCategoria.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro");
            }
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            ListaGrid();
            this.DgvCategoria.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DgvCategoria.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
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
            TxtCategoria.Text = string.Empty;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
