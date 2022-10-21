using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoCS.Observers
{
    public class EnviaEmail : IAcaoAposCadastroPessoa
    {
        public void Executar(Pessoa pessoa)
        {
            Console.WriteLine($"Envia email para pessoa: {pessoa.Nome}");
        }
    }
}