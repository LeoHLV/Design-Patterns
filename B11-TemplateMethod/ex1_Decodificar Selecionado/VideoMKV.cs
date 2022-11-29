namespace TemplateMethod
{
    public class VideoMKV : VideoPlayer
    {
        public override void DecodeVideoFormato()
        {
            Console.WriteLine("O video esta sendo processado com o Decoder MKV");
        }
    }
}