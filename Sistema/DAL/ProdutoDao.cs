using System;
using Sistema.Modelo;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            cmd.CommandText = "insert into tb_produto values(@fk_produto, @desc_produto, @valor)";
            cmd.Parameters.AddWithValue("@fk_produto", categoriaId);
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

            return Mensagem;
        }

    }
}
