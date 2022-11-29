using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adapter.Domain;

namespace Adapter.Adaptee
{
    public class SistemaMensalidades
    {
        public void CalcularMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                //utiliza uma logica para calcular a mensalidade
                Console.WriteLine($"Aluno {aluno.Nome}" +
                    $"- Valor da mensalidade R$ {aluno.Mensalidade}"
                );
            }
        }
    }
}