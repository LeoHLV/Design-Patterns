using System.Collections;
using System.Text;

namespace FactoryMethod.Pizzarias
{
    // Product ( entrada de pedidos )
    public abstract class AbsPizza
    {
        protected string Nome { get; set; }
        protected string massa { get; set; }
        protected string molho { get; set; }
        protected ArrayList ingredientes = new ArrayList();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Preparando " + Nome + "\n");
            sb.Append(massa + "\n");
            sb.Append(molho + "\n");
            sb.Append("Ingredientes: " + "\n");
            foreach (string ingrediente in ingredientes)
            {
                sb.Append("\t" + ingrediente + "\n");
            }
            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());
            return sb.ToString();
        }

        protected virtual string Cozinhar() => "Cozinhar por 25 minutos a 350 graus\n";
        protected virtual string Fatiar() => "Fatiar a piza em 8 pedaços \n";
        protected virtual string Embalar() => "Embalar a pizza com embalagem oficial \n";
    }
}