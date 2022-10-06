using EstudoCS.Decorators;

namespace EstudoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto("Camisa", 300);

            // utilizando unico
            // sera feito o calculo de 300 * 0.1 = 30
            var impostoUnico = new ICB();
            var valorDoImposto = impostoUnico.Calcular(produto);
            Console.WriteLine($"Valor do imposto: {valorDoImposto}");

            // utilizando imposto encadeado
            // sera feito o calculo de (300 * 0.1) + (300 * 0.05) = 30 + 15 = 45
            var impostoEncadeado = new ICB(new ICC());
            var valorImpostoEncadeado = impostoEncadeado.Calcular(produto);
            Console.WriteLine($"Valor do imposto Encadeado: {valorImpostoEncadeado}");

        }
    }
}
