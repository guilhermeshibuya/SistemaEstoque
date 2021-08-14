using System;
using Sistema.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Sistema.DAL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Apresentacao
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();

            lstProdutos.View = View.Details;
            lstProdutos.FullRowSelect = true;

            lstProdutos.Columns.Add("Código estoque", 130);
            lstProdutos.Columns.Add("Quantidade", 100);
            lstProdutos.Columns.Add("Valor", 100);
            lstProdutos.Columns.Add("Descrição", 454);
            lstProdutos.Columns.Add("Subtotal", 100);
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            ComboEstoque();
            ComboFornecedor();
        }

        private void btnAdcProd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                ListViewItem item = new ListViewItem(new[] { cmbEstoque.SelectedValue.ToString(), txtQuantidade.Text, txtValor.Text, cmbEstoque.GetItemText(cmbEstoque.SelectedItem), (double.Parse(txtValor.Text) * int.Parse(txtQuantidade.Text)).ToString("F2") });
                lstProdutos.Items.Add(item);
                cmbFornecedor.Enabled = false;
            }
            else
            {
                MessageBox.Show("Insira uma quantidade válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtQuantidade.Text = string.Empty;
        }

        private void btnRemoverProd_Click(object sender, EventArgs e)
        {
            try
            {
                lstProdutos.SelectedItems[0].Remove();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lstProdutos.Items.Count != 0)
            {
                Fornecedor fornecedor = new Fornecedor(int.Parse(cmbFornecedor.SelectedValue.ToString()));

                List<CompraEstoque> listaCompraEstoque = new List<CompraEstoque>();

                foreach (ListViewItem lst in lstProdutos.Items)
                {
                    int codEstoque = int.Parse(lst.SubItems[0].Text);
                    int quant = int.Parse(lst.SubItems[1].Text);
                    double valor = double.Parse(lst.SubItems[2].Text);

                    CompraEstoque compraEstoque = new CompraEstoque(codEstoque, quant, valor);

                    listaCompraEstoque.Add(compraEstoque);
                }

                Compra compra = new Compra(fornecedor, DateTime.Now, listaCompraEstoque);

                string mensagem = compra.RealizarCompra();

                if (compra.Tem)
                {
                    MessageBox.Show(mensagem, "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstProdutos.Clear();
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstProdutos.Clear();
                }
                cmbFornecedor.Enabled = true;
            }
            else
            {
                MessageBox.Show("Não há produtos no carrinho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ComboFornecedor()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select cod_fornecedor, nome from tb_fornecedor order by nome";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbFornecedor.DataSource = dt;
                cmbFornecedor.ValueMember = "cod_fornecedor";
                cmbFornecedor.DisplayMember = "nome";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstProdutos.Columns[e.ColumnIndex].Width;
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

                txtValor.Text = dr["valor"].ToString();
            }
            con.Desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
