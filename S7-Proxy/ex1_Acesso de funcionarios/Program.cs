namespace Proxy_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Exemplo de implementação do padrão Proxy ###");

            //acesso Programador
            Console.WriteLine("\nFuncionario com perfil : 'Programdor' acessando " +
            "a Pasta Compartilhada Proxy");

            var funci1 = new Funcionario("Leonardo", "123456", "Progragamdor");
            var pastaProxy1 = new PastaCompartilhadaProxy(funci1);
            pastaProxy1.OperacaoDeLeituraGravacao();

            //acesso Usuario
            Console.WriteLine("\nFuncionario com perfil : 'Usuario' acessando a Pasta " +
               "Compartilhada Proxy");

            var funci2 = new Funcionario("Amanda", "123456", "Usuario");
            var pastaProxy2 = new PastaCompartilhadaProxy(funci2);
            pastaProxy2.OperacaoDeLeituraGravacao();

            //acesso Ceo
            Console.WriteLine("\nFuncionario com perfil : 'Usuario' acessando a Pasta " +
               "Compartilhada Proxy");

            var funci3 = new Funcionario("Bill Gates", "876513", "Ceo");
            var pastaProxy3 = new PastaCompartilhadaProxy(funci3);
            pastaProxy3.OperacaoDeLeituraGravacao();
        }
    }
}