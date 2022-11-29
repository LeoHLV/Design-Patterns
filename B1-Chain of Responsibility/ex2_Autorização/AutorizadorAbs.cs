namespace ChainOfResposability_ex1
{
    public abstract class AutorizadorAbs
    {
        protected AutorizadorAbs? _autorizador;
        public void ProximoAutorizador(AutorizadorAbs autorizador)
        {
            _autorizador = autorizador;
        }
        public abstract void AutorizarLicenca(string nome, int dias);
    }
}