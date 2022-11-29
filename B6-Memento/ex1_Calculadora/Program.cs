namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Padrão Memento ###");
            Console.WriteLine("Calcula a soma de dois numeros e armazena o estado");

            // cria instancia do tipo ICalculadora
            ICalculadora calculadora = new Calculadora();

            // Atribui dois numeros
            calculadora.SetPrimeiroNumero(10);
            calculadora.SetSegundoNumero(100);

            // retorna o resultado
            Console.WriteLine($"### Estado 1 : {calculadora.GetCalculoResultado()}");

            // armazena o resultado caso ocorra um erro
            ICaretaker memento = calculadora.BackupUltimoCalculo();

            // atribui outro numero
            Console.WriteLine("\nCalcula uma nova soma de dois numeros\n");

            calculadora.SetPrimeiroNumero(17);

            // atribui um segundo numero incorreto e calcula
            calculadora.SetSegundoNumero(-290);

            // exibe resultado
            Console.WriteLine($"Estado 2 : {calculadora.GetCalculoResultado()}");
            Console.WriteLine("\nRestaura o resultado da soma anterior\n");

            // realização operacional para desfazer a ultima operação(CTRL+Z, Undo)
            calculadora.RestauraUltimoCalculo(memento);

            // restaura o resulado do estadoarmazenado
            Console.WriteLine($"### Estado 1 : {calculadora.GetCalculoResultado()}");
        }
    }
}