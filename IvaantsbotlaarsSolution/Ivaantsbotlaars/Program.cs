namespace Ivaantsbotlaars
{
     class Program
    {
        static void Main(string[] arg)
        {
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}