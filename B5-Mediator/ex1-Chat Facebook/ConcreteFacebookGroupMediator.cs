namespace Mediator
{
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            // mensagem não sera recebida por quem a estiver enviando
            foreach (var i in userList)
            {
                if (i != user) { i.Receive(message); }
            }
        }
    }
}