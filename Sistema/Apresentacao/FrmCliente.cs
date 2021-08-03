using System;
using Sistema.Modelo;
using Sistema.DAL;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            ControleCliente controle = new ControleCliente();
            string mensagem = controle.Cadastrar(txt_nome.Text, txt_telefone.Text, txt_cpf.Text);
            if (controle.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }
    }
}
