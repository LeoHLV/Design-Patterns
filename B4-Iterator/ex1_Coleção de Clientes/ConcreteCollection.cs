namespace ex1_ColecaoClientes
{
    //ConcreteAggregate
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        //Cria o Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Conta os itens
        public int Count
        {
            get { return listaClientes.Count; }
        }

        //Adiciona itens na coleção
        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        //Retorna um item da coleção
        public Cliente GetCliente(int posicao)
        {
            return listaClientes[posicao];
        }
    }
}