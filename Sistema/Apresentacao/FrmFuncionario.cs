using System;
using Sistema.Modelo;
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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(txt_nome.Text, txt_cpf.Text, txt_telefone.Text);
            string mensagem = funcionario.Cadastrar();
            if (funcionario.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(funcionario.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_nome.Text = string.Empty;
            txt_cpf.Text = string.Empty;
            txt_telefone.Text = string.Empty;
        }
    }
}
