using System;

namespace MaxPlayle.ArgumentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("This application was executed with the following arguments:");
            foreach (string argument in args) {
                Console.WriteLine("* " + argument);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Press any key to exit this application!");
            Console.ReadKey();
        }
    }
}
