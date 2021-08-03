using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    abstract class Pessoa
    {
        public string _nome;
        public string _cpf;
        public string Telefone { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (value != null && value.Length == 14)
                {
                    _cpf = value;
                }
            }
        }
    }
}
