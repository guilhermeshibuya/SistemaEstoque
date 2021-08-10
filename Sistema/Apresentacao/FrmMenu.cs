using System;
using Sistema.Apresentacao;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            statusStrip1.ForeColor = Color.FromArgb(220, 220, 221);
        }

        private void btn_cad_categoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.Show();
        }

        private void btn_cad_produto_Click(object sender, EventArgs e)
        {
            FrmProdutos frm = new FrmProdutos();
            frm.Show();
        }

        private void btn_cad_usuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            lbl_status_data.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_status_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Show();
        }

        private void btn_cad_funcionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario frm = new FrmFuncionario();
            frm.Show();
        }

        private void btn_consulta_produto_Click(object sender, EventArgs e)
        {
            FrmEstoque frm = new FrmEstoque();
            frm.Show();
        }
    }
}
