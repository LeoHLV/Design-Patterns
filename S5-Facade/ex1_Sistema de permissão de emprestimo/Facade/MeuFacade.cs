using Facade_ex1.Subsistemas;

namespace Facade_ex1.Facade
{
    public class MeuFacade
    {
        // fields para cada classe
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        // entrada de cada valor de classe
        public MeuFacade()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"{cliente.Nome} esta pleitando um empréstimo no valor de {valor:c}\n");
            cadastro.CadastroCliente(cliente);

            bool ConcederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                //Verifica Serasa
                Console.WriteLine($"Cliente {cliente.Nome} possui restriçãono SERASA");
                ConcederEmprestimo = false;
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                //Verifica Cadin
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no CADIN");
                ConcederEmprestimo = false;
            }
            else if (!limite.PossuiLimiteCredito(cliente, valor))
            {
                //Verifica se o cliente tem limite de credito para o valor requerido
                Console.WriteLine($"O Cliente {cliente.Nome} possui limite de crédito inferior a {valor:c}\n.");
                ConcederEmprestimo = false;
            }
            // true-concede false-nega
            return ConcederEmprestimo;
        }
    }
}