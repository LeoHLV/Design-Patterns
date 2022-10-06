namespace EstudoCS.Observers
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
        private List<IAcaoAposCadastroPessoa> _acaoAposCadastro;

        public Pessoa(string nome, DateTime dataNascimento, string cpf, string rg, string sexo, string apelido, string celular, string telefone, string email, List<IAcaoAposCadastroPessoa> acoesAposCadastro)
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
            _acaoAposCadastro = acoesAposCadastro;
        }

        public void SalvarPessoa()
        {
            Console.WriteLine("Pessoa salva"); ;
            foreach (var i in _acaoAposCadastro)
            {
                i.Executar(this);
            }
        }
    }
}