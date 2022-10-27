using System;

namespace Ex1_ContatoPessoa.Builder
{
    public class PessoaBuilder
    {
        private string _nome;
        public DateTime _dataNascimento;
        private string _cpf;
        private string _rg;
        private string _sexo;
        private string _apelido;
        private string _celular;
        private string _telefone;
        private string _email;

        public Pessoa Construir()
        {
            return new Pessoa(_nome, _dataNascimento, _cpf, _rg, _sexo, _apelido, _celular, _telefone, _email);
        }

        public PessoaBuilder SetNome(string nome)
        {
            _nome = nome;
            return this;
        }
        public PessoaBuilder SetDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }
        public PessoaBuilder SetCpf(string cpf)
        {
            _cpf = cpf;
            return this;
        }
        public PessoaBuilder SetRg(string rg)
        {
            _rg = rg;
            return this;
        }
        public PessoaBuilder SetSexo(string sexo)
        {
            _sexo = sexo;
            return this;
        }
        public PessoaBuilder SetApelido(string apelido)
        {
            _apelido = apelido;
            return this;
        }
        public PessoaBuilder SetCelular(string celular)
        {
            _celular = celular;
            return this;
        }
        public PessoaBuilder SetTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }
        public PessoaBuilder SetEmail(string email)
        {
            _email = email;
            return this;
        }
    }
}