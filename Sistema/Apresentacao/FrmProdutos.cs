using System;
using Sistema.Modelo;
using System.Data.SqlClient;
using Sistema.DAL;
using System.Data;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            ListaCombo();
            ListaGrid();
            DgvProdutos.Columns[0].HeaderText = "Código";
            DgvProdutos.Columns[1].HeaderText = "Categoria";
            DgvProdutos.Columns[2].HeaderText = "Descrição";
            DgvProdutos.Columns[3].HeaderText = "Valor";
            DgvProdutos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvProdutos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvProdutos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvProdutos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_nome.Text) && txt_nome.Text.Length > 1 
                && !String.IsNullOrWhiteSpace(txt_valor.Text))
            {
                double resultado;
                bool verificar = Double.TryParse(txt_valor.Text, out resultado);
                if (verificar && resultado > 0)
                {
                    Produto prod = new Produto(txt_nome.Text, Convert.ToDouble(txt_valor.Text), Convert.ToInt32(cmb_Categoria.SelectedValue));
                    string mensagem = prod.Cadastrar();
                    if (prod.Tem)
                    {
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListaGrid();
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Campo vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            txt_nome.Text = string.Empty;
            txt_valor.Text = string.Empty;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int codProduto = int.Parse(DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());

            Produto prod = new Produto();
            string mensagem = prod.Deletar(codProduto);
            if (prod.Tem)
            {
                MessageBox.Show(mensagem, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaGrid();
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!txt_nome.Text.Equals(DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[2].Value.ToString()) 
                || !txt_valor.Text.Equals(DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[3].Value.ToString()) 
                || !cmb_Categoria.SelectedValue.ToString().Equals(DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[1].Value.ToString()))
            {
                int produtoId = int.Parse(DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());

                Produto prod = new Produto(produtoId, txt_nome.Text, Convert.ToDouble(txt_valor.Text), Convert.ToInt32(cmb_Categoria.SelectedValue));
                string mensagem = prod.Alterar();
                
                if (prod.Tem)
                {
                    MessageBox.Show(mensagem, "Dados alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaGrid();
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_nome.Text = string.Empty;
                txt_valor.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Nenhum dado foi alterado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string categoriaId = DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[1].Value.ToString();
            string descricao = DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[2].Value.ToString();
            string valor = DgvProdutos.Rows[DgvProdutos.CurrentRow.Index].Cells[3].Value.ToString();

            for (int i = 0; i < cmb_Categoria.Items.Count; i++)
            {
                cmb_Categoria.SelectedIndex = i;
                if (cmb_Categoria.SelectedValue.ToString().Equals(categoriaId))
                {
                    cmb_Categoria.SelectedItem = cmb_Categoria.Items[i];
                    break;
                }
            }
            txt_nome.Text = descricao;
            txt_valor.Text = valor;
        }

        private void ListaCombo()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select id_categoria, desc_categoria from tb_categoria order by desc_categoria";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                
                cmb_Categoria.DataSource = dt;
                cmb_Categoria.ValueMember = "id_categoria";
                cmb_Categoria.DisplayMember = "desc_categoria"; 

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaGrid()
        {
            Conexao con = new Conexao();
            string strSql = "select * from tb_produto";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                DgvProdutos.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = string.Empty;
            txt_valor.Text = string.Empty;
            DgvProdutos.CurrentCell = null;
            DgvProdutos.ClearSelection();
            cmb_Categoria.SelectedItem = cmb_Categoria.Items[0];
        }
    }
}
