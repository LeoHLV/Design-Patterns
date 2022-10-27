namespace Facade_ex1.Subsistemas
{
    // verifica o risco do cliente e se está registrado no Serasa
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }
    }
}