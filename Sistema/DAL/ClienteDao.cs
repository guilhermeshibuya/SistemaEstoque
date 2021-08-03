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
            if (nome != null && nome.Length > 1 && cpf != null && cpf.Length == 14 && telefone != null)
            {
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
            } else
            {
                Mensagem = "Campo inválido ou vazio!";
            }
            return Mensagem;
        }
    }
}
