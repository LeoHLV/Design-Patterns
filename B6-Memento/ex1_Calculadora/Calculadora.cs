namespace Memento
{
    public class Calculadora : ICalculadora
    {
        private int _primeiroNumero;
        private int _segundoNumero;

        //corresponde ao metodo CreateMemento()
        public ICaretaker BackupUltimoCalculo()
        {
            //cria u mobjeto memento usado para restaurar os dois numeros
            return new Memento(_primeiroNumero, _segundoNumero);
        }

        // retorna resultado da soma dos dois numeros
        public int GetCalculoResultado()
        {
            return _primeiroNumero + _segundoNumero;
        }

        public void RestauraUltimoCalculo(ICaretaker memento)
        {
            _primeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
            _segundoNumero = ((IOriginator)memento).GetPrimeiroNumero();
        }

        public void SetPrimeiroNumero(int num1)
        {
            _primeiroNumero = num1;
        }

        public void SetSegundoNumero(int num2)
        {
            _segundoNumero = num2;
        }
    }
}