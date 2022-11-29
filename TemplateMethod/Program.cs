namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Template Method ###");
            Console.WriteLine("Exemplo de implementação\n");

            Console.WriteLine("------------------ Video Player - video MP4 ------------------");
            VideoPlayer arquivoVideo = new VideoMP4();
            arquivoVideo.CarregarArquivo();
            arquivoVideo.DecodeVideoFormato();
            arquivoVideo.IniciarExecucao();

            Console.WriteLine("------------------ Video Player - video MKV ------------------");
            arquivoVideo = new VideoMKV();
            arquivoVideo.CarregarArquivo();
            arquivoVideo.DecodeVideoFormato();
            arquivoVideo.IniciarExecucao();
        }
    }
}