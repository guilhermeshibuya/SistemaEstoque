using System;
using Sistema.Modelo;
using Sistema.DAL;
using System.Data.SqlClient;
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Lista();
            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[1].HeaderText = "Nome";
            dgvCliente.Columns[2].HeaderText = "Telefone";
            dgvCliente.Columns[3].HeaderText = "CPF";

            dgvCliente.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCliente.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCliente.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCliente.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCliente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_nome.Text, txt_cpf.Text, txt_telefone.Text);
            string mensagem = cliente.Cadastrar();
            if (cliente.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista();
            }
            else
            {
                MessageBox.Show(cliente.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_nome.Text = string.Empty;
            txt_cpf.Text = string.Empty;
            txt_telefone.Text = string.Empty;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!txt_nome.Text.Equals(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[1].Value.ToString()) 
                || !txt_telefone.Text.Equals(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[2].Value.ToString()) 
                || !txt_cpf.Text.Equals(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[3].Value.ToString()))
            {
                int clienteId = int.Parse(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString());

                Cliente cliente = new Cliente(clienteId, txt_nome.Text, txt_cpf.Text, txt_telefone.Text);
                string mensagem = cliente.Alterar();

                if (cliente.Tem)
                {
                    MessageBox.Show(mensagem, "Dados alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lista();
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_nome.Text = string.Empty;
                txt_cpf.Text = string.Empty;
                txt_telefone.Text = string.Empty;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int clienteId = int.Parse(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString());

            Cliente cliente = new Cliente(clienteId);

            string mensagem = cliente.Deletar();

            if (cliente.Tem)
            {
                MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista();
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nome = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[1].Value.ToString();
            string telefone = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[2].Value.ToString();
            string cpf = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[3].Value.ToString();

            txt_cpf.Text = cpf;
            txt_nome.Text = nome;
            txt_telefone.Text = telefone;
        }

        public void Lista()
        {
            Conexao con = new Conexao();
            string strSql = "select * from tb_cliente";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dgvCliente.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_cpf.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_telefone.Text = string.Empty;
            dgvCliente.ClearSelection();
            dgvCliente.CurrentCell = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
