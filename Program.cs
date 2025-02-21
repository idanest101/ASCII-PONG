namespace ASCII_Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            while (true) 
            {
                Console.Clear();
                engine._run();
                Thread.Sleep(10);
            }
        }
    }
}
