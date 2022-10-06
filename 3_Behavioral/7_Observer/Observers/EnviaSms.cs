using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoCS.Observers
{
    public class EnviaSms : IAcaoAposCadastroPessoa
    {
        public void Executar(Pessoa pessoa)
        {
            Console.WriteLine($"Enviando sms para pessoa: {pessoa.Nome}");
        }

    }
}