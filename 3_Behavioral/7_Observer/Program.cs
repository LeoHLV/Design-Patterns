using EstudoCS.Observers;

namespace EstudoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // mesmo faltando referencia de alguns elementos o costrutor ajusta automaticamente
            var pessoa = new PessoaBuilder()
                        .SetNome("Gustavo")
                        .SetDataNascimento(Convert.ToDateTime("1991-01-28"))
                        .SetCpf("21212121212")
                        .SetEmail("teste@gmail.com")
                        .SetAcaoAposCadastroPessoa(new EnviaEmail())
                        .Construir();

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Cpf);
            Console.WriteLine(pessoa.DataNascimento);
            Console.WriteLine(pessoa.Email);
            pessoa.SalvarPessoa();
        }
    }
}
