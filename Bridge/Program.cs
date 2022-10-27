using Bridge.AbsRefined;
using Bridge.ConcreteImplementor;
using Bridge.Domain;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * AbsRedefine recebe via constructor em tempo de execução
             * o tipo especifico de formato para gerar o arquivo e usa a classe
             * base AbsGerarArquivo para obter uma instancia de
             * IGeraArquivo (Bridge)
            */
            var calculaSalario = new CalculaSalario(new GeraXML());

            // define os dados do funcionario
            var funcionario = new Funcionario
            {
                Id = 101,
                Nome = "Paulo",
                SalarioBase = 3000,
                Incentivo = 2000
            };

            // processa o salario
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            // altera o valor do incentivo em tempo de execucao
            funcionario.Incentivo = 2500;

            // altera o formato para gerar o arquivo em tempo de execucao
            calculaSalario = new CalculaSalario(new GeraJson());
            calculaSalario.ProcessaSalarioFuncionario(funcionario);
        }
    }
}