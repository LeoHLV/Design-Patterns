namespace Flyweight_ex1
{
    // concrete FlyWeight
    public class Circulo : IForma
    {
        // estado extrinseco nao compartilhado
        public string Cor { get; set; }

        // estado intrinseco (cache) valores constantes
        private int x = 10;
        private int y = 20;
        private int raio = 30;

        public void SetCor(string Cor)
        {
            this.Cor = Cor;
        }

        public void Desenhar()
        {
            Console.WriteLine($"Círculo: Desenhar() [Cor: {Cor} x:{x}, y:{y}, raio: {raio}]");
        }
    }
}
