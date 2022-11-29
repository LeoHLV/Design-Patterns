using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        // contem a implementacao e a transformacao de array em list
        private SistemaMensalidades sistemaMensalidades = new SistemaMensalidades();

        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Curso = null;
            string Mensalidade = null;

            var listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0) { Curso = alunosArray[i, j]; }
                    else if (j == 1) { Curso = alunosArray[i, j]; }
                    else { Mensalidade = alunosArray[i, j]; }
                }
                //criar a lista de objetos aluno
                listaAlunos.Add(new Aluno(Convert.ToInt32(Id), Nome,
                                        Curso, Convert.ToDecimal(Mensalidade)));
            }
            Console.WriteLine("O adapter converteu o Array[] para List<> de Alunos\n");;
            Console.WriteLine("E delegou  ao SistemaMensalidades o processamento" +
            "da mensagem dos alunos\n");

            sistemaMensalidades.CalcularMensalidade(listaAlunos);
        }
    }
}