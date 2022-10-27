using System;
using Ex1_ContatoPessoa.Builder;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // mesmo faltando referencia de alguns elementos o costrutor ajusta automaticamente
            var pessoa = new PessoaBuilder()
                .SetNome("Gustavo")
                .SetDataNascimento(Convert.ToDateTime("1991-01-28"))
                .SetCpf("21212121212")
                .SetEmail("teste@gmail.com")
                .Construir();
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Cpf);
                Console.WriteLine(pessoa.DataNascimento);
        }
    }
}