namespace ex1_ColecaoClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome,int id)
        {
            Nome = nome;
            Id = id;
        }
    }
}