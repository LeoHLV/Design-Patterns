namespace Memento
{
    public interface IOriginator
    {
        //Permite o originator restaurar o seu estado
        int GetPrimeiroNumero();
        int GetSegundoNumero();
    }
}