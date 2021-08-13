using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class VendaEstoque
    {
        public int CodEstoque { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public VendaEstoque(int codEstoque, int quantidade, double valor)
        {
            CodEstoque = codEstoque;
            Quantidade = quantidade;
            Valor = valor * quantidade;
        }
    }
}
