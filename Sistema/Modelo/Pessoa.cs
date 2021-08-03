using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    abstract class Pessoa
    {
        private string _nome;
        private string _cpf;
        private string _telefone;

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
                if (value != null)
                {
                    _cpf = value;
                }
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (value != null)
                {
                    _nome = value;
                }
            }
        }

    }
}
