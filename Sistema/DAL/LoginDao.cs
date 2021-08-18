using System;
using System.Data.SqlClient;

namespace Sistema.DAL
{
    class LoginDao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from tb_login where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }

        public String cadastrar(String login, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha) && login.Length >= 5 && senha.Length >= 5)
            {
                cmd.CommandText = "insert into tb_login values(@log, @senha);";
                cmd.Parameters.AddWithValue("@log", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o banco de dados";
                }
            } else
            {
                this.mensagem = "Campo(s) inválido(s)!";
            }
            
            return mensagem;
        }
    }
}
