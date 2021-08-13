using System;
using Sistema.Modelo;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Sistema.DAL
{
    public class VendaDao
    {
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        Conexao con = new Conexao();
        public string Mensagem;
        public bool Tem;

        public string RealizarVenda(Funcionario funcionario, Cliente cliente, DateTime data, List<VendaEstoque> vendaEstoque)
        {
            Tem = false;

            cmd.CommandText = "insert into tb_venda values(@fk_cod_funcionario, @fk_cod_cliente, @data)";
            cmd.Parameters.AddWithValue("@fk_cod_funcionario", funcionario.FuncionarioId);
            cmd.Parameters.AddWithValue("@fk_cod_cliente", cliente.ClienteId);
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

            foreach (VendaEstoque item in vendaEstoque)
            {
                cmd2.CommandText = "insert into tb_venda_estoque values(IDENT_CURRENT('tb_venda'), @fk_cod_estoque, @quantidade, @valor) update tb_estoque set quantidade = quantidade - @quantidade where cod_estoque = @fk_cod_estoque";
                cmd2.Parameters.AddWithValue("@fk_cod_estoque", item.CodEstoque);
                cmd2.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd2.Parameters.AddWithValue("@valor", item.Valor);
                
                try
                {
                    cmd2.Connection = con.Conectar();
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    con.Desconectar();
                    Mensagem = "Venda realizada com sucesso!";
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
