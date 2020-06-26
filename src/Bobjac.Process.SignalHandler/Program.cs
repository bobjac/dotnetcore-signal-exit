using System;

namespace Bobjac.Process.SignalHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AppDomain.CurrentDomain.ProcessExit += (s, e) =>
            {
                Console.WriteLine("Exiting!");
            };

            System.Threading.Thread.Sleep(5000);
        }
    }
}
