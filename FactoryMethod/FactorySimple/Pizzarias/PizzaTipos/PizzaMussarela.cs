namespace FactorySimple.Pizzarias.PizzaTipos
{
    public class PizzaMussarela : AbsPizza
    {
        public PizzaMussarela()
        {
            Nome = "Pizza de Mussarela";
        }

        public override void Preparar() =>
                Console.WriteLine($"Preparando {Nome}");
        public override void Assar(int tempo) =>
                Console.WriteLine($"{Nome} assando por tempo {tempo} min.");
        public override void Embalar() =>
                Console.WriteLine($"Embalando {Nome}");
    }
}