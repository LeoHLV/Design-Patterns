namespace FactoryMethod.Pizzarias.PizzasSP
{
    public class PizzaMussarelaSP : AbsPizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela paulista";
            massa = "Massa fina crocante paulista";
            molho= "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}