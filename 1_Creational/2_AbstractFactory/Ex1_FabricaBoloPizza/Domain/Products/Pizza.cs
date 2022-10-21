using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public abstract class Pizza : MassaBase
    {
        protected Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}