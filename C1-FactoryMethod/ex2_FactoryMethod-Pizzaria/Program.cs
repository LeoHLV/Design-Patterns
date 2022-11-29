using FactoryMethod.Pizzarias;
using FactoryMethod.Pizzarias.Fabricas;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Pizzaria=====");

            Console.WriteLine("Informe o local São Paulo (S)  Rio de Janeiro (R)");
            var localEscolhido = Console.ReadLine().ToUpper();
            Console.WriteLine("Escolha a pizza Mussarela(M)  Calabreza (C)");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                AbsPizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
                var pizza = pizzaria.MontaPizza(pizzaEscolhida);
                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluída co msucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}