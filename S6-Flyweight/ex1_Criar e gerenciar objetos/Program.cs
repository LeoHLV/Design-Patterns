namespace Flyweight_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\n### Círculos Amarelos");
             for (int i = 0; i < 3; i++)
             {
                 var circulo = (Circulo)FormaFactory.GetForma("circulo");
                 circulo.SetCor("amarelo");
                 circulo.Desenhar();
             }
             Console.WriteLine("\n### Círculos Verdes");
             for (int i = 0; i < 3; i++)
             {
                 var circulo = (Circulo)FormaFactory.GetForma("circulo");
                 circulo.SetCor("verde");
                 circulo.Desenhar();
             }
             Console.WriteLine("\n### Círculos Azuis");
             for (int i = 0; i < 3; i++)
             {
                 var circulo = (Circulo)FormaFactory.GetForma("circulo");
                 circulo.SetCor("azul");
                 circulo.Desenhar();
             }
             Console.WriteLine("\n### Círculos Vermelhos");
             for (int i = 0; i < 3; i++)
             {
                 var circulo = (Circulo)FormaFactory.GetForma("circulo");
                 circulo.SetCor("vermelho");
                 circulo.Desenhar();
             }
        }
    }
}