using Departamento_ex1.Component;

namespace Departamento_ex1.Composite
{
    //representa o Composite
    public class Organizacao : HoraTrabalhadaAbs
    {
        protected List<HoraTrabalhadaAbs> departamentos = new List<HoraTrabalhadaAbs>();
        public override void Add(HoraTrabalhadaAbs component)
        {
            departamentos.Add(component);
        }

        public override void Remove(HoraTrabalhadaAbs component)
        {
            departamentos.Remove(component);
        }

        //funcionalidade comum
        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;
            foreach (var i in departamentos)
            {
                horasTrabalhadasDepartamento += i.GetHoraTrabalhada();
            }
            Console.WriteLine($"{Nome} registrou um total de [{horasTrabalhadasDepartamento}] horas\n");
            return horasTrabalhadasDepartamento;
        }
    }
}