namespace Prototype.ConcretePrototype
{
    public class Acessorio
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}