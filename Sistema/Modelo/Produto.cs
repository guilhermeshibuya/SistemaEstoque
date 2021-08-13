using System;
using Sistema.Modelo;
using Sistema.DAL;
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

        public Produto(int produtoId, string nome, double preco, int categoriaId)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Preco = preco;
            CategoriaId = categoriaId;
        }

        public string Cadastrar()
        {
            ProdutoDao prodDao = new ProdutoDao();
            Mensagem = prodDao.Cadastrar(Nome, Preco, CategoriaId);
            if (prodDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }

        public string Deletar(int produtoId)
        {
            ProdutoDao prodDao = new ProdutoDao();
            Mensagem = prodDao.Deletar(produtoId);

            if (prodDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }

        public string Alterar()
        {
            ProdutoDao prodDao = new ProdutoDao();
            Mensagem = prodDao.Alterar(ProdutoId, Nome, Preco, CategoriaId);

            if (prodDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }
    }
}
