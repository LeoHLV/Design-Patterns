using Departamento_ex1.Composite;

namespace Departamento_ex1.Component
{
    // representa o Component
    public abstract class HoraTrabalhadaAbs
    {
        public string Nome { get; set; }
        public abstract int GetHoraTrabalhada();

        public HoraTrabalhadaAbs()
        {

        }

        // apenas para incluir os funcionarios no departamento
        public virtual void Add(HoraTrabalhadaAbs component)
        {
            throw new NotImplementedException();
        }
        // somente para ilustrar :)
        public virtual void Remove(HoraTrabalhadaAbs component)
        {
            throw new NotImplementedException();
        }
    }
}