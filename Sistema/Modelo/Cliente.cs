using Sistema.DAL;

namespace Sistema.Modelo
{
    public class Cliente : Pessoa
    {
        public int ClienteId { get; set; }
        public bool Tem;
        public string Mensagem;

        public Cliente()
        {
        }

        public Cliente(int clienteId)
        {
            ClienteId = clienteId;
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public Cliente(int clienteId, string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            ClienteId = clienteId;
        }

        public override string Cadastrar()
        {
            if (VerificarDados() == true)
            {
                ClienteDao cad = new ClienteDao();
                Mensagem = cad.Cadastrar(Nome, Telefone, Cpf);
                if (cad.Tem)
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

        public string Deletar()
        {
            ClienteDao clienteDao = new ClienteDao();
            Mensagem = clienteDao.Deletar(ClienteId);

            if (clienteDao.Tem)
            {
                this.Tem = true;
            }

            return Mensagem;
        }

        public string Alterar()
        {
            if (VerificarDados() == true)
            {
                ClienteDao clienteDao = new ClienteDao();
                Mensagem = clienteDao.Alterar(ClienteId, Nome, Telefone, Cpf);

                if (clienteDao.Tem)
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
