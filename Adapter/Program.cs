using Adapter.Adapter;
using Adapter.Target;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alunosArray = new string[5, 4]
            {
                {"101","Maria", "Artes", "1000"},
                {"102","Pedro", "Engenharia Artes", "2000"},
                {"103","Biance", "Veterinaria", "3000"},
                {"104","Maria", "Artes", "950"},
                {"105","Sergio", "Desenho", "850"}
            };
            ITarget target = new AlunoAdapter();
            Console.WriteLine("SistemaMensalidade passa o " +
                                        "Array de string para o Adapter\n");
            target.ProcessaCalculoMensalidade(alunosArray);
        }
    }
}