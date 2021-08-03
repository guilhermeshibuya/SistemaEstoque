using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void listaGrid()
        {
            string strSql = "select * from tb_categoria";
            Conexao con = new Conexao();
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);
                
                dgv_cadastro.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro");
            }
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
        }
    }
}
