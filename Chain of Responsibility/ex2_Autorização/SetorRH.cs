namespace ChainOfResposability_ex1
{
    public class SetorRH : AutorizadorAbs
    {
        private int ALCADA_DIAS = 30;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_DIAS) { AprovarLicenca(nome, dias); }
            else
            {
                Console.WriteLine($"\nNão foi possível autorizar a licença "+
                $"de {dias} para {nome}.\n *** Comunique a Diretoria! ***\n");
            }
        }
        private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O setor de RH aprovou {dias} dias " +
                $"de licença remunerada para : {nome}\n");
        }
    }
}