﻿using System;
using Sistema.Modelo;
using Sistema.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    class Funcionario : Pessoa
    {
        public bool Tem;
        public string Mensagem;
        public int FuncionarioId { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
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


    }
}
