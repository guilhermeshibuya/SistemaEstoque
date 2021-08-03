using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    class ClienteDao
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string Mensagem;
        public bool Tem;
        public string Cadastrar(string nome, string telefone, string cpf)
        {
            Tem = false;

            cmd.CommandText = "insert into tb_cliente values(@nome, @telefone, @cpf)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@cpf", cpf);

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
