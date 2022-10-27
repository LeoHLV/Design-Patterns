namespace ex1_Pedidos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Padrão Command ##\n");

            // cria uma instancia para chef para poder preparar o pedido

            //Receiver
            Chef chef = new Chef();

            //prato
            Pedido pedido = new Pedido(chef, "Prato");
            Garcom garcom = new Garcom(pedido);
            garcom.Executar();
            //Sobremesa
            pedido = new Pedido(chef, "Sobremesa");
            garcom = new Garcom(pedido);
            garcom.Executar();
        }
    }
}