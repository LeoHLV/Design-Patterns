namespace FactoryMethod.Pizzarias.PizzasRJ
{
    public class PizzaMussarelaRJ : AbsPizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmesão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}