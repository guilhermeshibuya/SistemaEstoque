using System;
using System.Linq;

namespace Sistema.Modelo
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public bool VerificarDados()
        {
            if ((!String.IsNullOrWhiteSpace(Nome) && Nome.Length > 1) 
                && (!String.IsNullOrWhiteSpace(Cpf) && Cpf.Length == 14) 
                && (!String.IsNullOrWhiteSpace(Telefone) && Telefone.Length == 19) && !Nome.All(char.IsDigit))
                return true;
            else
                return false;
        }

        public abstract string Cadastrar();
    }
}
