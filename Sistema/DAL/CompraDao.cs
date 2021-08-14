using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Sistema.Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    public class CompraDao
    {
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        Conexao con = new Conexao();
        public string Mensagem;
        public bool Tem;

        public string RealizarCompra(Fornecedor fornecedor, DateTime data, List<CompraEstoque> compraEstoque)
        {
            Tem = false;
            cmd.CommandText = "insert into tb_compra values(@fk_cod_fornecedor, @data)";
            cmd.Parameters.AddWithValue("@fk_cod_fornecedor", fornecedor.FornecedorId);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException)
            {
                Mensagem = "Erro com o banco de dados!";
            }

            foreach (CompraEstoque item in compraEstoque)
            {
                cmd2.CommandText = "insert into tb_compra_estoque values(@fk_cod_estoque, IDENT_CURRENT('tb_compra'), @quantidade, @valor) " +
                    "update tb_estoque set quantidade = quantidade + @quantidade where cod_estoque = @fk_cod_estoque " +
                    "insert into tb_entrada_saida values(@fk_cod_estoque, 'E', @quantidade, @data)";
                cmd2.Parameters.AddWithValue("@fk_cod_estoque", item.EstoqueId);
                cmd2.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd2.Parameters.AddWithValue("@valor", item.Valor);
                cmd2.Parameters.AddWithValue("@data", data);

                try
                {
                    cmd2.Connection = con.Conectar();
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    con.Desconectar();
                    Mensagem = "Compra realizada com sucesso!";
                    Tem = true;
                }
                catch (SqlException)
                {
                    Mensagem = "Erro com o banco de dados!";
                }
            }

            return Mensagem;
        }
    }
}
