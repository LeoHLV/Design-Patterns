using System.Collections.Generic;
namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Padrão Visitor ###");

            var carros = new List<Carro>();
            carros.Add(new Carro() { Nome = "A1", Preco = 2000M, Modelo = "Mercedes" });
            carros.Add(new Carro() { Nome = "458", Preco = 3500M, Modelo = "Ferrari" });
            carros.Add(new Carro() { Nome = "718 GTS", Preco = 2800M, Modelo = "Porsche" });

            List<ILoja> lojas = new List<ILoja>();

            Console.WriteLine("Precos normais dos carros\n");

            foreach (var i in carros)
            {
                Console.WriteLine($" {i.Modelo} {i.Nome} : ${i.Preco}");
                lojas.Add(i);
            }

            Console.WriteLine("\nPreços dos carros com desconto");
            Console.WriteLine("Aplicando o padrão Visitor");

            Console.WriteLine("Novos Preços com desconto de 12%\n");

            //Exibe o preco de cada item usando o Visitor
            var precoVisitor = new PrecoVisitor();
            
            foreach (var i in lojas)
            {
                i.Visit(precoVisitor);
            }
        }
    }
}