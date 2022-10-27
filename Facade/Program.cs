using Facade_ex1.Facade;
using Facade_ex1.Subsistemas;

namespace Facade_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // representa usuario do subsistema
            // cria uma instancia do facade
            MeuFacade concedeCreditoFacade = new MeuFacade();

            // cria instancia de um novo cliente informando o nome
            var cliente1 = new Cliente("Leonardo");

            //utiliza o facade para verificar condicoes de concecao ou nao
            bool resultado = concedeCreditoFacade.ConcederEmprestimo(cliente1, 199000.00);

            // exibe resultado
            Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Reprovado"));
        }
    }
}