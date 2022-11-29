using Departamento_ex1.Composite;
using Departamento_ex1.Leaf;

namespace Departamento_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var organizacao = new Organizacao { Nome = "JcmSoft inc. " };

            // Dep TI
            var departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Samuel", Horas = 8 });

            // Dep Contabilidade
            var departamentoContabilidade = new Organizacao { Nome = " TI " };
            departamentoContabilidade.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoContabilidade.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });

            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);
            organizacao.GetHoraTrabalhada();
        }
    }
}