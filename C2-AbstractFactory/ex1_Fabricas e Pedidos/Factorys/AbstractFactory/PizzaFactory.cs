using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factorys.AbstractFactory
{
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;
            switch (tipoPizza)
            {
                case TipoPizza.Mussarela : { return new PizzaMussarela(); }
                case TipoPizza.Calabreza : { return new PizzaCalabreza(); }

                default: throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}