using System.Collections;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }
        public ArrayList Ingredientes = new ArrayList();

        protected MassaBase(string nome, TipoMassa tipo)
        {
            Nome = nome;
            TipoMassa = tipo;
        }
    }
}