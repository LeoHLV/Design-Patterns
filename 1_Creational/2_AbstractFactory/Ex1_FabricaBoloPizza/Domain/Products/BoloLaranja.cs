namespace AbstractFactory.Domain.Products
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}