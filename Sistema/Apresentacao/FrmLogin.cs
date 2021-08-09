using Sistema.Modelo;
using System;
using System.Threading;
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
    public partial class FrmLogin : Form
    {
        Thread t1;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleLogin controle = new ControleLogin();
            controle.acessar(txt_usuario.Text, txt_senha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    t1 = new Thread(AbrirMenu);
                    t1.SetApartmentState(ApartmentState.MTA);
                    t1.Start();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void AbrirMenu(object obj)
        {
            Application.Run(new FrmMenu());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
