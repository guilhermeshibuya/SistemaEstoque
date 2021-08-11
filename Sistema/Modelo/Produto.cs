using System;
using Sistema.Modelo;
using Sistema.DAL;
using Sistema.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int CategoriaId { get; set; }
        public bool Tem;
        public string Mensagem;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int categoriaId)
        {
            Nome = nome;
            Preco = preco;
            CategoriaId = categoriaId;
        }

        public bool VerificarDados()
        {
            if (!String.IsNullOrWhiteSpace(Nome) && Nome.Length > 1 && !String.IsNullOrWhiteSpace(Preco.ToString()) && Preco > 0.0)
                return true;
            else
                return false;
        }

        public string Cadastrar()
        {
            if (VerificarDados() == true)
            {
                ProdutoDao prodDao = new ProdutoDao();
                Mensagem = prodDao.Cadastrar(Nome, Preco, CategoriaId);
                if (prodDao.Tem)
                {
                    this.Tem = true;
                }
                return Mensagem;
            }
            else
            {
                Mensagem = "Campo inválido ou vazio";
                return Mensagem;
            }
        }
    }
}
