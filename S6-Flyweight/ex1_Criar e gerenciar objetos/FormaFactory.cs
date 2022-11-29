namespace Flyweight_ex1
{
    // Flyweight Factory
    public class FormaFactory
    {
        // Dictionary utilizado como colecao de objetos IForma para armazenar em cash objetos
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        //cria e gerencia objetos
        public static IForma GetForma(string chave)
        {
            IForma forma;

            if (formas.ContainsKey(chave)) { return formas[chave]; }
            else if (chave == "circulo")
            {
                forma = new Circulo();
                formas.Add("circulo", forma);
            }
            else { throw new Exception("Este tipo de objeto não pode ser criado"); }

            return forma;
        }
    }
}