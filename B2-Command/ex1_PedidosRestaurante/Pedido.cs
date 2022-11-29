namespace ex1_Pedidos
{
    public class Pedido : CommandAbs
    {
        private Chef Chef { get; set; }
        public string Acao { get; set; }

        public Pedido(Chef chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }

        public override void Execute()
        {
            if (Acao.Equals("Prato")) { Chef.PreparandoPrato(); }
            else { Chef.PreparandoSobremesa(); }
        }
    }
}