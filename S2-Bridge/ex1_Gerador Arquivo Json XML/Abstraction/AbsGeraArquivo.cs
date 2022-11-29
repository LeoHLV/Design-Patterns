using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class AbsGeraArquivo
    {
        protected IGeraArquivo _geraArquivo;
        protected AbsGeraArquivo(IGeraArquivo geraArquivo){
            _geraArquivo = geraArquivo;
        }
        public virtual void GravaArquivo(Funcionario funcionario){
            _geraArquivo.GravaArquivo(funcionario);
        }
    }
}