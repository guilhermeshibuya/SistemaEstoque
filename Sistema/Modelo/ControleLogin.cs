using Sistema.DAL;
using System;

namespace Sistema.Modelo
{
    public class ControleLogin
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDao loginDal = new LoginDao();

            tem = loginDal.verificarLogin(login, senha);

            if (!loginDal.mensagem.Equals(""))  
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }

        public String cadastrar(String login, String senha, String confSenha)
        {
            LoginDao loginDal = new LoginDao();
            this.mensagem = loginDal.cadastrar(login, senha, confSenha);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
