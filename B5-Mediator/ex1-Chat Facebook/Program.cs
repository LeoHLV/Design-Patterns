namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

            User pessoa_1 = new ConcreteUser(facebookMediator, "nomePessoa_1");
            User pessoa_2 = new ConcreteUser(facebookMediator, "nomePessoa_2");
            User pessoa_3 = new ConcreteUser(facebookMediator, "nomePessoa_3");
            User pessoa_4 = new ConcreteUser(facebookMediator, "nomePessoa_4");

            facebookMediator.RegisterUser(pessoa_1);
            facebookMediator.RegisterUser(pessoa_2);
            facebookMediator.RegisterUser(pessoa_3);
            facebookMediator.RegisterUser(pessoa_4);

            pessoa_1.Send("O canal está apresentando uma serie de projetos");
            pessoa_4.Send("Onde posso encontrar os videos");
            pessoa_1.Send("Veja a playlist em: ...");
        }
    }
}