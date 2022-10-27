using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}