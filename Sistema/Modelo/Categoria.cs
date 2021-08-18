using Sistema.DAL;

namespace Sistema.Modelo
{
    public class Categoria
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

        public Categoria(int categoriaId, string nome)
        {
            CategoriaId = categoriaId;
            Nome = nome;
        }

        public string Cadastrar()
        {
            CategoriaDao catDao = new CategoriaDao();
            Mensagem = catDao.Cadastrar(Nome);
            if (catDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }

        public string Deletar(int categoriaId)
        {
            CategoriaDao catDao = new CategoriaDao();
            Mensagem = catDao.Deletar(categoriaId);

            if (catDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }

        public string Alterar()
        {
            CategoriaDao catDao = new CategoriaDao();
            Mensagem = catDao.Alterar(CategoriaId, Nome);

            if (catDao.Tem)
            {
                this.Tem = true;
            }
            return Mensagem;
        }


    }
}
