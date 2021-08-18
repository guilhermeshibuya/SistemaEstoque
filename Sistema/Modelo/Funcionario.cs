using Sistema.DAL;

namespace Sistema.Modelo
{
    public class Funcionario : Pessoa
    {
        public int FuncionarioId { get; set; }
        public bool Tem;
        public string Mensagem;

        public Funcionario()
        {
        }

        public Funcionario(int funcionarioId)
        {
            FuncionarioId = funcionarioId;
        }

        public Funcionario(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public Funcionario(int funcionarioId, string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            FuncionarioId = funcionarioId;
        }

        public override string Cadastrar()
        {
            if (VerificarDados() == true)
            {
                FuncionarioDao cad = new FuncionarioDao();
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

        public string Alterar()
        {
            if (VerificarDados() == true)
            {
                FuncionarioDao funcionarioDao = new FuncionarioDao();
                Mensagem = funcionarioDao.Alterar(FuncionarioId, Nome, Telefone, Cpf);

                if (funcionarioDao.Tem)
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
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            Mensagem = funcionarioDao.Deletar(FuncionarioId);

            if (funcionarioDao.Tem)
            {
                this.Tem = true;
            }

            return Mensagem;
        }
    }
}
