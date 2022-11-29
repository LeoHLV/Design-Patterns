namespace Proxy_ex1
{
    // RealSubject
    //Objeto que queremos utilizar de forma mais eficiente utilizando proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            // define operação a ser realizada na pasta Real
            Console.WriteLine("### Operação de Leitura e Escrita " + "na pasta compartilhada ###");
        }
    }
}