using FactorySimple.Pizzarias;

namespace FactorySimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Pizzaria=====");
            Console.WriteLine("Informee a Pizza (C)alabreza ou (M)ussarela \n");
            var tipo = Console.ReadLine().ToUpper();
            try
            {
                AbsPizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10); // tempo de preparo adicionado
                pizza.Embalar();
                Console.WriteLine("Pizza concluída");
            }
            catch (Exception ex) { Console.WriteLine("Erro :" + ex.Message); }
        }
    }
}
