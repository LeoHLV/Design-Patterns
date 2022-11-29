using PadraoProjetoState.Estados;

namespace PadraoProjetoState
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido("Camisa", 200);

            try
            {
                pedido.EmAndamento();
                pedido.Aprovado();

                // exception, pedido ja foi aprovado
                // pedido.Reprovado();

                pedido.Finalizado();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}