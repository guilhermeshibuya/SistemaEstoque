using System;
using System.Data.SqlClient;
using Sistema.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Sistema.Apresentacao
{
    public partial class FrmEntradaSaida : Form
    {
        public FrmEntradaSaida()
        {
            InitializeComponent();
        }

        private void FrmEntradaSaida_Load(object sender, EventArgs e)
        {
            Combo();
            Mes();
            Lista();

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Quantidade";
            dataGridView1.Columns[3].HeaderText = "Valor";
            dataGridView1.Columns[4].HeaderText = "Data";
            dataGridView1.Columns[5].HeaderText = "Descrição";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }


        private void Combo()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select cod_tipo_ind, desc_ind from tb_tipo_ind";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbTipo.DataSource = dt;
                cmbTipo.ValueMember = "cod_tipo_ind";
                cmbTipo.DisplayMember = "desc_ind";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mes()
        {
            try
            {
                Conexao con = new Conexao();
                string strSql = "select cod_mes, desc_mes from tb_mes";
                SqlCommand cmd = new SqlCommand(strSql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbMes.DataSource = dt;
                cmbMes.ValueMember = "cod_mes";
                cmbMes.DisplayMember = "desc_mes";

                con.Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrar()
        {
            if (!String.IsNullOrWhiteSpace(txtAno.Text) && txtAno.Text.Length == 4)
            {
                Conexao con = new Conexao();

                string strSql = "select es.cod_entrada_saida, es.ind_entrada_saida, es.quantidade, es.valor, convert(varchar(10), es.data_entrada_saida, 20), prod.desc_produto from tb_entrada_saida es " +
                "join tb_estoque est on est.cod_estoque = es.fk_cod_estoque " +
                "join tb_produto prod on prod.cod_produto = est.fk_cod_produto " +
                "where month(es.data_entrada_saida) = " + cmbMes.SelectedValue +
                " and year(es.data_entrada_saida) = " + txtAno.Text +
                " and es.ind_entrada_saida = '" + cmbTipo.SelectedValue + "'";
                SqlCommand objCommand = null;
                objCommand = new SqlCommand(strSql, con.Conectar());

                try
                {
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                    DataTable dt = new DataTable();
                    objAdp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro com o banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Desconectar();
            }
            else
            {
                MessageBox.Show("Insira um ano válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista()
        {
            Conexao con = new Conexao();
            string strSql = "select es.cod_entrada_saida, es.ind_entrada_saida, es.quantidade, es.valor, es.data_entrada_saida, prod.desc_produto from tb_entrada_saida es " +
                "join tb_estoque est on est.cod_estoque = fk_cod_estoque " +
                "join tb_produto prod on prod.cod_produto = fk_cod_produto";
            SqlCommand objCommand = null;
            objCommand = new SqlCommand(strSql, con.Conectar());

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objAdp.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Desconectar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            txtAno.Text = string.Empty;
            Lista();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4);
                doc.SetMargins(15, 15, 15, 40);
                string caminho = @"C:\Users\guilh\Documents\" + "relatorio.pdf";

                PdfWriter wrtiter = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph titulo = new Paragraph();
                titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 30);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Relatório\n\n");
                doc.Add(titulo);

                iTextSharp.text.Font fonte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10);

                PdfPTable tabela = new PdfPTable(6);
                float[] widths = new float[] { 0.6f, 0.5f, 0.9f, 1f, 1f, 4f };
                tabela.AddCell(new PdfPCell(new Phrase("Código", fonte)));
                tabela.AddCell(new PdfPCell(new Phrase("Tipo", fonte)));
                tabela.AddCell(new PdfPCell(new Phrase("Quantidade", fonte)));
                tabela.AddCell(new PdfPCell(new Phrase("Valor", fonte)));
                tabela.AddCell(new PdfPCell(new Phrase("Data", fonte)));
                tabela.AddCell(new PdfPCell(new Phrase("Descrição", fonte)));
                tabela.SetWidths(widths);

                double valorTotal = 0;

                foreach (DataGridViewRow linha in dataGridView1.Rows)
                {
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[0].Value.ToString(), fonte)));
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[1].Value.ToString(), fonte)));
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[2].Value.ToString(), fonte)));
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[3].Value.ToString(), fonte)));
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[4].Value.ToString(), fonte)));
                    tabela.AddCell(new PdfPCell(new Phrase(linha.Cells[5].Value.ToString(), fonte)));

                    valorTotal += double.Parse(linha.Cells[3].Value.ToString());
                }
                string strValorTotal = "R$: " + valorTotal.ToString("F2");
                PdfPCell celula1 = new PdfPCell(new Phrase("Valor total: ", fonte));
                celula1.Colspan = 2;
                tabela.AddCell(celula1);

                PdfPCell celula2 = new PdfPCell(new Phrase(strValorTotal, fonte));
                celula2.Colspan = 4;
                tabela.AddCell(celula2);

                doc.Add(tabela);
                doc.Close();

                MessageBox.Show("Relatório gerado com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
