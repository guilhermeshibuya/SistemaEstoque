using System;
using Sistema.Modelo;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    class Cliente : Pessoa
    {
        public bool Tem;
        public string Mensagem;

        public int IdCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public bool VerificarDados()
        {
            if ((!String.IsNullOrEmpty(Nome) && Nome.Length > 1) && (!String.IsNullOrEmpty(Cpf) && Cpf.Length == 11) && (!String.IsNullOrEmpty(Telefone) && Telefone.Length == 13))
                return true;
            else
                return false;
        }

        public string Cadastrar()
        {
            if (VerificarDados() == true)
            {
                ClienteDao cad = new ClienteDao();
                Mensagem = cad.Cadastrar(Nome, Telefone, Cpf);
                if (cad.Tem)
                {
                    this.Tem = true;
                }
                return Mensagem;
            }
            else
            {
                Mensagem = "Campo Inválido ou vazio";
                return Mensagem;
            }
            
        }
    }
}
