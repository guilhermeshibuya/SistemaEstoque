using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Sistema.DAL;
using Sistema.Modelo;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Apresentacao
{
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {

            InitializeComponent();
            lstProdutos.View = View.Details;
            lstProdutos.FullRowSelect = true;

            lstProdutos.Columns.Add("Código estoque", 150);
            lstProdutos.Columns.Add("Quantidade", 70);
            lstProdutos.Columns.Add("Valor", 200);
            lstProdutos.Columns.Add("Descrição", 354);
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            ComboEstoque();
            ComboFuncionario();
            ComboCliente();
        }

        private void btnAdcProd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantEstoque.Text) && !String.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                if (double.Parse(txtQuantEstoque.Text) >= double.Parse(txtQuantidade.Text))
                {
                    ListViewItem item = new ListViewItem(new[] { cmbEstoque.SelectedValue.ToString(), txtQuantidade.Text, txtValor.Text, cmbEstoque.GetItemText(cmbEstoque.SelectedItem) });
                    lstProdutos.Items.Add(item);
                    cmbCliente.Enabled = false;
                    cmbFuncionario.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Quantidade insuficiente no estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira uma quantidade válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtQuantidade.Text = string.Empty;

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario(int.Parse(cmbFuncionario.SelectedValue.ToString()));
            Cliente cliente = new Cliente(int.Parse(cmbCliente.SelectedValue.ToString()));

            List<VendaEstoque> listaVendaEstoque = new List<VendaEstoque>();

            foreach (ListViewItem lst in lstProdutos.Items)
            {
                int codEstoque = int.Parse(lst.SubItems[0].Text);
                int quant = int.Parse(lst.SubItems[1].Text);
                double valor = double.Parse(lst.SubItems[2].Text);
                VendaEstoque vendaEstoque = new VendaEstoque(codEstoque, quant, valor);
                listaVendaEstoque.Add(vendaEstoque);
            }

            Venda venda = new Venda(func, cliente, DateTime.Now, listaVendaEstoque);

            string mensagem = venda.RealizarVenda();
            if (venda.Tem)
            {
                MessageBox.Show(mensagem, "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstProdutos.Clear();
            }
            else
            {
                MessageBox.Show(venda.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstProdutos.Clear();
            }
            cmbCliente.Enabled = true;
            cmbFuncionario.Enabled = true;
        }

        private void cmbEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            string strSql = "select est.quantidade, prod.valor from tb_estoque est " +
                "join tb_produto prod " +
                "on est.fk_cod_produto = prod.cod_produto where est.cod_estoque = '" + cmbEstoque.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                txtQuantEstoque.Text = dr["quantidade"].ToString();
                txtValor.Text = dr["valor"].ToString();
            }
            con.Desconectar();
        }

        private void ComboEstoque()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select est.cod_estoque, prod.desc_produto from tb_estoque est " +
                    "join tb_produto prod " +
                    "on est.fk_cod_produto = prod.cod_produto " +
                    "order by prod.desc_produto";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbEstoque.DataSource = dt;
                cmbEstoque.ValueMember = "cod_estoque";
                cmbEstoque.DisplayMember = "desc_produto";


                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboFuncionario()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select cod_funcionario, nome from tb_funcionario order by nome";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.ValueMember = "cod_funcionario";
                cmbFuncionario.DisplayMember = "nome";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboCliente()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select cod_cliente, nome from tb_cliente order by nome";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbCliente.DataSource = dt;
                cmbCliente.ValueMember = "cod_cliente";
                cmbCliente.DisplayMember = "nome";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
