namespace ChainOfResposability_ex1
{
    public class SupervisorEquipe : AutorizadorAbs
    {
        private int ALCADA_DIAS = 15;
        public override void AutorizarLicenca(string nome, int dias)
        {
             if (dias <= ALCADA_DIAS) { AprovarLicenca(nome, dias); }
            else { _autorizador?.AutorizarLicenca(nome, dias); }
        }
           private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor da Equipe aprovou {dias} dias " +
                $"de licença remunerada para : {nome}\n");
        }
    }
}