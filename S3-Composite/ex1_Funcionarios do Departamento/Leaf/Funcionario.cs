using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Departamento_ex1.Component;

namespace Departamento_ex1.Leaf
{
    public class Funcionario : HoraTrabalhadaAbs
    {
        //representa o Leaf
        public int Id { get; set; }
        public int Horas { get; set; }

        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O funcionário {Id}-{Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}