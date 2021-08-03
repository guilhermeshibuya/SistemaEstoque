using System;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    class ControleCliente
    {
        public bool Tem;
        public string Mensagem;

        public string Cadastrar(string nome, string telefone, string cpf)
        {
            ClienteDao cad = new ClienteDao();
            Mensagem = cad.Cadastrar(nome, telefone, cpf);
            if (cad.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }
    }
}
