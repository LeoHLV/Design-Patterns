namespace Facade_ex1.Subsistemas
{
    // Clientes
    public class Cadastro
    {
        public void CadastroCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluído.");
        }
    }
}