namespace ChainOfResposability_ex1
{
    public class GerenteProjeto : AutorizadorAbs
    {
        // licença valida por 5 dias
        private int ALCADA_DIAS = 5;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_DIAS) { AprovarLicenca(nome, dias); }
            else { _autorizador?.AutorizarLicenca(nome, dias); }
        }

        private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Gerente de Projetos aprovou {dias} dias " +
                $"de licença remunerada para : {nome}\n");
        }
    }
}