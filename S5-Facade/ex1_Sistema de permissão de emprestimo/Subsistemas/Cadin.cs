namespace Facade_ex1.Subsistemas
{
    // verifica o risco do cliente e se está registrado no Cadin
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine("Verificando o CADIN para o cliente " + cliente.Nome);
            return false;
        }
    }
}