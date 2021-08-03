﻿using System;
using System.Windows.Forms;
using Sistema.Modelo;

namespace Sistema
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ControleLogin controle = new ControleLogin();
            String mensagem = controle.cadastrar(txt_login.Text, txt_senha.Text, txt_senha2.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
