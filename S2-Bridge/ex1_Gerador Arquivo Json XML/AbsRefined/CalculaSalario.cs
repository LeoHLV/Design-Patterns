using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.AbsRefined
{
    public class CalculaSalario : AbsGeraArquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo) { }
        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do Salário Total para o funcionário {funcionario.Id} " +
            $": R$ {funcionario.SalarioTotal}");

            _geraArquivo.GravaArquivo(funcionario);
        }
    }
}