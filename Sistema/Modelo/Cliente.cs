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

        public int VerificarDados()
        {
            if ((!String.IsNullOrWhiteSpace(Nome) && Nome.Length > 1) && (!String.IsNullOrWhiteSpace(Cpf) && Cpf.Length == 14) && (!String.IsNullOrWhiteSpace(Telefone) && Telefone.Length == 19))
                return 1;
            else
                return 0;
        }

        public string Cadastrar()
        {
            if (VerificarDados() == 1)
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
