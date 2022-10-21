namespace AbstractFactory.Domain.Products
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}