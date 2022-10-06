namespace FactoryMethod.Pizzarias.PizzasSP
{
    public class PizzaCalabrezaSP : AbsPizza
    {
        public PizzaCalabrezaSP()
        {
            Nome = "Pizza de calabreza paulista com muita calabreza";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Fatias de calabreza defumada especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}