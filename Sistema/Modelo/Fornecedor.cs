using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(int fornecedorId)
        {
            FornecedorId = fornecedorId;
        }

        public Fornecedor(int fornecedorId, string nome, string cnpj, string telefone)
        {
            FornecedorId = fornecedorId;
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
        }

        public string Cadastrar()
        {
            return "a";
        }

        public string Deletar()
        {
            return "a";
        }

        public string Atualizar()
        {
            return "a";
        }
    }
}
