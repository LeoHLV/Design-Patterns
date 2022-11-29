namespace ChainOfResposability_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instancia dos autorizadores
            var gerenteProjeto = new GerenteProjeto();
            var supervisorEquipe = new SupervisorEquipe();
            var setorRH = new SetorRH();

            // instancia do seletor de autorizacao
            // por hierarquia inicia no gerente e caso nao possua inicia no supervisor ou RH
            gerenteProjeto.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(setorRH);

            // solicitações
            gerenteProjeto.AutorizarLicenca("Carlos", 5);
            gerenteProjeto.AutorizarLicenca("Amanda", 14);
            gerenteProjeto.AutorizarLicenca("Benedito", 18);
            gerenteProjeto.AutorizarLicenca("Janice", 30);
            gerenteProjeto.AutorizarLicenca("Felipe", 50);
        }
    }
}