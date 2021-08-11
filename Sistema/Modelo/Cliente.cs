using System;
using Sistema.Modelo;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Cliente : Pessoa
    {
        public int ClienteId { get; set; }
        public bool Tem;
        public string Mensagem;

        public Cliente()
        {
        }

        public Cliente(int cleinteId)
        {
            ClienteId = cleinteId;
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override string Cadastrar()
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
                Mensagem = "Campo inválido ou vazio";
                return Mensagem;
            }
            
        }
    }
}
