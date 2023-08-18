using System.Runtime.CompilerServices;

namespace RabbitMQScaling
{
    internal class Program
    {
        private volatile static bool shouldShutDown = false;
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                shouldShutDown = true;

            };
            Console.WriteLine("Application Started. Press Ctrl+C or send SIGTERM to stop");
            while (!shouldShutDown)
            {
                JobMethod();
            }

            
        }

        private static void JobMethod()
        {
            Console.WriteLine("Started");
            Console.WriteLine("Working...1");
            Thread.Sleep(1000);
            Console.WriteLine("Working...2");
            Thread.Sleep(1000);
            Console.WriteLine("Working...3");
            Thread.Sleep(1000);
            Console.WriteLine("Working...4");
            Thread.Sleep(1000);
            Console.WriteLine("Working...5");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
    }
}