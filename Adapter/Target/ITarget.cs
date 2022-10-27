namespace Adapter.Target
{
    public interface ITarget
    {
        //define o contrato
        void ProcessaCalculoMensalidade(string[,] alunoArray);
    }
}