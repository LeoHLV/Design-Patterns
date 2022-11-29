namespace FactorySimple.Pizzarias
{
    public abstract class AbsPizza
    {
        // propriedades de entrada para a Pizza
        public string Nome { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();
    }
}