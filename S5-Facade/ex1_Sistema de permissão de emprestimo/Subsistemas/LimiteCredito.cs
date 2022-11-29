namespace Facade_ex1.Subsistemas
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine("Verificando o limite de credito do cliente " + cliente.Nome);

            if (valor > 200000.00) { return false; }
            else { return true; }
        }
    }
}