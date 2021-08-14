using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class CompraEstoque
    {
        public int EstoqueId { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public CompraEstoque(int estoqueId, int quantidade, double valor)
        {
            EstoqueId = estoqueId;
            Quantidade = quantidade;
            Valor = valor * quantidade;
        }
    }
}
