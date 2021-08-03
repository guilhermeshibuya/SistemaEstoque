using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Produto
    {
        public double Preco { get; set; }

        private string _nome;

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

        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _categoria = value;
                }
            }
        }
    }
}
