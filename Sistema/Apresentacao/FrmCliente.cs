﻿using System;
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
using System.Drawing.Drawing2D;

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
            Cliente cliente = new Cliente(txt_nome.Text, txt_cpf.Text, txt_telefone.Text);
            string mensagem = cliente.Cadastrar();
            if (cliente.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(cliente.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
