using System;
using Sistema.DAL;
using Sistema.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Venda
    {
        public int VendaId { get; set; }
        public Funcionario Funcionario { get; set; } = new Funcionario();
        public Cliente Cliente { get; set; } = new Cliente();
        public DateTime Data { get; set; } = new DateTime();
        public List<VendaEstoque> VendaEstoque { get; set; } = new List<VendaEstoque>();
        public string Mensagem;
        public bool Tem;

        public Venda()
        {
        }

        public Venda(Funcionario funcionario, Cliente cliente, DateTime data, List<VendaEstoque> vendaEstoque)
        {
            Funcionario.FuncionarioId = funcionario.FuncionarioId;
            Cliente.ClienteId = cliente.ClienteId;
            Data = data;
            VendaEstoque = vendaEstoque;
        }

        public string RealizarVenda()
        {
            VendaDao vendaDao = new VendaDao();
            Mensagem = vendaDao.RealizarVenda(Funcionario, Cliente, Data, VendaEstoque);
            if (vendaDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }

    }
}
