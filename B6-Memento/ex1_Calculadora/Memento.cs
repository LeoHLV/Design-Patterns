namespace Memento
{
    public class Memento : ICaretaker, IOriginator
    {
        private int _primeiroNumero;
        private int _segundoNumero;

        public Memento(int numero1,int numero2)
        {
            _primeiroNumero = numero1;
            _segundoNumero = numero2;
        }

        int IOriginator.GetPrimeiroNumero()
        {
            return _primeiroNumero;
        }

        int IOriginator.GetSegundoNumero()
        {
            return _segundoNumero;
        }
    }
}