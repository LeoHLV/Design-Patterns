namespace ex1_ColecaoClientes
{
    // Iterator
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}