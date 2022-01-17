using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IPessoa
    {
        void Nome(string nome);
        void Sobrenome(string sobrenome);
        void Cpf(int cpf);
    }

    class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int Cpf { get; set; }

        void IPessoa.Nome(string nome)
        {
            this.Nome = nome;

        }

        void IPessoa.Sobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        void IPessoa.Cpf(int cpf)
        {
            this.Cpf = cpf;
        }
    }
}