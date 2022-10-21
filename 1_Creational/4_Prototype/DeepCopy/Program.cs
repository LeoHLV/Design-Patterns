using Prototype.ConcretePrototype;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado = new Soldado();
            soldado.Nome = "Soldado1";
            soldado.Arma = "Fuzil HK G36";
            soldado.Acessorio = new Acessorio { Nome = "Visor Noturno" };
            // clone1 do objeto original
            Soldado soldado_clone1 = (Soldado)soldado.Clone();
            soldado_clone1.Nome = "Soldado clone1";
            soldado_clone1.Arma = "Fuzil Kalashinikov";
            soldado_clone1.Acessorio.Nome = "Colete Especial";
            // clone1 do objeto original
            Soldado soldado_clone2 = (Soldado)soldado.Clone();
            soldado_clone2.Nome = "Soldado clone2";
            soldado_clone2.Arma = "Fuzil AK105";
            soldado_clone2.Acessorio.Nome = "Capacete MK1";

            // exibe valores do soldado original
            Console.WriteLine(">> Original");
            Console.WriteLine($"{soldado.Nome} - {soldado.Arma}");
            Console.WriteLine($"{soldado.Acessorio.Nome}\n");
            // exibe valores do soldado clone 1
            Console.WriteLine(">> Clone-1");
            Console.WriteLine($"{soldado_clone1.Nome} - {soldado_clone1.Arma}");
            Console.WriteLine($"{soldado_clone1.Acessorio.Nome}\n");
            // exibe valores do soldado clone 2
            Console.WriteLine(">> Clone-2");
            Console.WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma}");
            Console.WriteLine($"{soldado_clone2.Acessorio.Nome}\n");
        }
    }
}
