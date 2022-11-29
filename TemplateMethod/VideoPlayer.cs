namespace TemplateMethod
{
    public abstract class VideoPlayer
    {
        //Template Method
        public void ExecutarVideo()
        {
            CarregarArquivo();
            DecodeVideoFormato();
            IniciarExecucao();
        }
        //procedimento padrao
        public void CarregarArquivo()
        {
            Console.WriteLine("Arquivo de video carregado...\n");
        }

        //procedimento que sera sobrescrito
        public abstract void DecodeVideoFormato();

        //procedimento padrao
        public void IniciarExecucao()
        {
            Console.WriteLine("O video iniciou e execução...\n");
        }
    }
}