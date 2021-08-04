using System;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public bool Tem;
        public string Mensagem;

        public Categoria()
        {
        }

        public Categoria(string nome)
        {
            Nome = nome;
        }

        public bool VerificarNome()
        {
            if (!String.IsNullOrWhiteSpace(Nome) && Nome.Length > 1)
                return true;
            else
                return false;
        }

        public string Cadastrar()
        {
            if (VerificarNome() == true)
            {
                CategoriaDao catDao = new CategoriaDao();
                Mensagem = catDao.Cadastrar(Nome);
                if (catDao.Tem)
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
