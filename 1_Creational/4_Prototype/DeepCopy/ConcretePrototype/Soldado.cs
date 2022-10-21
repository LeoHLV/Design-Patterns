namespace Prototype.ConcretePrototype
{
     /*
      * ICloneable é um recurso proprio da linguagem C#
      * gera a classe Clone que permite gerar cópias
     */
    public class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public Soldado() { }
        public Soldado(Soldado s)
        {
            this.Nome = s.Nome;
            this.Arma = s.Arma;
            this.Acessorio = s.Acessorio;
        }

        public object Clone()
        {
            Soldado soldado = (Soldado)this.MemberwiseClone();
            soldado.Acessorio = (Acessorio)this.Acessorio.Clone();
            return soldado;
        }
    }
}