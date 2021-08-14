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

namespace Sistema.Apresentacao
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Lista();
            dgvFuncionario.Columns[0].HeaderText = "Código";
            dgvFuncionario.Columns[1].HeaderText = "Nome";
            dgvFuncionario.Columns[2].HeaderText = "Telefone";
            dgvFuncionario.Columns[3].HeaderText = "CPF";

            dgvFuncionario.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFuncionario.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFuncionario.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFuncionario.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFuncionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFuncionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFuncionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!txt_nome.Text.Equals(dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[1].Value.ToString())
                || !txt_telefone.Text.Equals(dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[3].Value.ToString())
                || !txt_cpf.Text.Equals(dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[2].Value.ToString()))
            {
                int funcionarioId = int.Parse(dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[0].Value.ToString());

                Funcionario funcionario = new Funcionario(funcionarioId, txt_nome.Text, txt_cpf.Text, txt_telefone.Text);
                string mensagem = funcionario.Alterar();

                if (funcionario.Tem)
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
            int funcionarioId = int.Parse(dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[0].Value.ToString());

            Funcionario funcionario = new Funcionario(funcionarioId);

            string mensagem = funcionario.Deletar();

            if (funcionario.Tem)
            {
                MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista();
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Lista()
        {
            Conexao con = new Conexao();
            string strSql = "select * from tb_funcionario";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dgvFuncionario.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nome = dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[1].Value.ToString();
            string telefone = dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[3].Value.ToString();
            string cpf = dgvFuncionario.Rows[dgvFuncionario.CurrentRow.Index].Cells[2].Value.ToString();

            txt_cpf.Text = cpf;
            txt_nome.Text = nome;
            txt_telefone.Text = telefone;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_cpf.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_telefone.Text = string.Empty;
            dgvFuncionario.ClearSelection();
            dgvFuncionario.CurrentCell = null;
        }
    }
}
