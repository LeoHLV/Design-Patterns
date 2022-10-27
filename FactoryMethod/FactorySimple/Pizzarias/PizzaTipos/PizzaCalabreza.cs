namespace FactorySimple.Pizzarias.PizzaTipos
{
    public class PizzaCalabreza : AbsPizza
    {
        public PizzaCalabreza()
        {
            Nome = "Pizza de Calabreza";
        }

        public override void Preparar() =>
                Console.WriteLine($"Preparando {Nome}");
        public override void Assar(int tempo) =>
                Console.WriteLine($"{Nome} assando por tempo {tempo} min.");
        public override void Embalar() =>
                Console.WriteLine($"Embalando {Nome}");
    }
}
