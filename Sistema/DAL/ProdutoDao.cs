using System;
using System.Data.SqlClient;

namespace Sistema.DAL
{
    class ProdutoDao
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string Mensagem;
        public bool Tem;

        public string Cadastrar(string nome, double valor, int categoriaId)
        {
            Tem = false;

            cmd.CommandText = "insert into tb_produto values(@fk_cod_categoria, @desc_produto, @valor) insert into tb_estoque values(IDENT_CURRENT('tb_produto'), 0)";
            cmd.Parameters.AddWithValue("@fk_cod_categoria", categoriaId);
            cmd.Parameters.AddWithValue("@desc_produto", nome);
            cmd.Parameters.AddWithValue("@valor", valor);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                Mensagem = "Cadastrado com sucesso!";
                Tem = true;
            }
            catch (SqlException)
            {
                Mensagem = "Erro com o banco de dados!";
            }
            catch (Exception)
            {
                Mensagem = "Erro!";
            }

            return Mensagem;
        }

        public string Deletar(int produtoId)
        {
            Tem = false;

            cmd.CommandText = "alter table tb_estoque nocheck constraint all delete from tb_produto where cod_produto = @produtoId alter table tb_estoque check constraint all";
            cmd.Parameters.AddWithValue("@produtoId", produtoId);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                Mensagem = "Produto deletado com sucesso!";
                Tem = true;
            }
            catch (SqlException)
            {
                Mensagem = "Erro com o banco de dados!";
            }

            return Mensagem;
        }

        public string Alterar(int produtoId, string nome, double valor, int categoriaId)
        {
            Tem = false;

            cmd.CommandText = "update tb_produto set fk_cod_categoria = @categoriaId, desc_produto = @desc_produto, valor = @valor where cod_produto = @cod_produto";
            cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
            cmd.Parameters.AddWithValue("@desc_produto", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@cod_produto", produtoId);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();

                Mensagem = "Dados alterados com sucesso!";
                Tem = true;
            }
            catch (SqlException)
            {
                Mensagem = "Erro com o banco de dados!";
            }

            return Mensagem;
        }

    }
}
