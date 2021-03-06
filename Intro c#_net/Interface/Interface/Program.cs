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

namespace Enum
{
    //Comeca do 0 e aumenta de 1 em 1. No caso Gabriela é 0, miguel 1 e etc. (indice)
    enum Pessoas
    {
        Gabriela,
        Miguel,
        João,
        Jorge,
        Aline
    }
}