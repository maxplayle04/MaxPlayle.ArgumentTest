using System;
using System.Linq;

namespace MaxPlayle.ArgumentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("MaxPlayle.ArgumentTest");
            Console.WriteLine("Allows the user to test which arguments are being sent to the application.");
            Console.WriteLine("--------------------------------");
            if (args.Length != 0) {
                Console.WriteLine("This application was executed with the following arguments:");
                foreach (string argument in args) {
                    Console.WriteLine("* " + argument);
                }
            }
            else {
                Console.WriteLine("* This application was not executed with any arguments...");
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Press any key to exit this application!");
            Console.ReadKey();
        }
    }
}
