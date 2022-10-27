using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza Calabreza",Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomates em cubos.");
        }
    }
}