using System.Collections.ObjectModel;
namespace ex1_ColecaoClientes
{
    public class Iterator : IAbstractIterator
    {
  private int current = 0;
        private int step = 1;
        private ConcreteCollection collection;
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Retorna o primeiro item
        public Cliente First()
        {
            current = 0;
            return collection.GetCliente(current);
        }
        // Retorna o proximo item
        public Cliente Next()
        {
            current += step;
            if (!IsDone)
            {
                return collection.GetCliente(current);
            }
            else
            {
                return null;
            }
        }
        // Verifica se a iteração terminou
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}