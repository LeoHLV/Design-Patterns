namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name)
        : base(mediator, name) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} : recebida <= {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} : enviada <= {message}\n");
            _mediator.SendMessage(message, this);
        }
    }
}