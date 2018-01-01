using System;

namespace cbo_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Inheritance example");

            new A().mB1(); // since inherits B
        }
    }
}
