using System.Text.Json;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario){
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioSerializado);

            Console.WriteLine($"Salário para o Funcionário : {funcionario.Nome} " +
            $"gerado com sucesso em : {nomeArquivo}");
        }
    }
}