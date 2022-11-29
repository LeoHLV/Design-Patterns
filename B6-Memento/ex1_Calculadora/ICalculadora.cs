namespace Memento
{
    //Define a interface para a implementação do Originator
    public interface ICalculadora
    {
        //CreateMemento
        ICaretaker BackupUltimoCalculo();

        //SetMemento
        void RestauraUltimoCalculo(ICaretaker memento);

        //servicos do Originator
        int GetCalculoResultado();
        void SetPrimeiroNumero(int num1);
        void SetSegundoNumero(int num2);
    }
}