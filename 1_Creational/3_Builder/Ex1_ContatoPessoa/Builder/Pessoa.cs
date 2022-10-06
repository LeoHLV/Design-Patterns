using System;

namespace Ex1_ContatoPessoa.Builder
{
    public class Pessoa
    {
        public string  Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Sexo { get; set; }
        public string Apelido { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, DateTime dataNascimento, string cpf, string rg, string sexo, string apelido, string celular, string telefone, string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            Apelido = apelido;
            Celular = celular;
            Telefone = telefone;
            Email = email;
        }
    }
}