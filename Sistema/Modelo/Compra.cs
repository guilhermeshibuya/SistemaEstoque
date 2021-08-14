using System;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Compra
    {
        public int CompraId { get; set; }
        public Fornecedor Fornecedor { get; set; } = new Fornecedor();
        public DateTime Data { get; set; }
        public List<CompraEstoque> CompraEstoque { get; set; } = new List<CompraEstoque>();
        public string Mensagem;
        public bool Tem;

        public Compra(Fornecedor fornecedor, DateTime data, List<CompraEstoque> compraEstoque)
        {
            Fornecedor.FornecedorId = fornecedor.FornecedorId;
            Data = data;
            CompraEstoque = compraEstoque;
        }

        public string RealizarCompra()
        {
            CompraDao compraDao = new CompraDao();
            Mensagem = compraDao.RealizarCompra(Fornecedor, Data, CompraEstoque);
            if (compraDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }
    }
}
