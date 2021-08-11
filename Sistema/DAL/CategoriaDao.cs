using System;
using System.Collections.Generic;
using Sistema.Modelo;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    class CategoriaDao
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string Mensagem;
        public bool Tem;

        public string Cadastrar(string nome)
        {
            Tem = false;

            cmd.CommandText = "insert into tb_categoria values(@desc_categoria)";
            cmd.Parameters.AddWithValue("@desc_categoria", nome);

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
