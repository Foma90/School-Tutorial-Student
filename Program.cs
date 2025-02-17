using System.Runtime.CompilerServices;

namespace Proekt_Rep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 1;
            Print();
        }

        static void Print()
        {
            Console.WriteLine($"{n++} {Console.ReadLine()}");
        }

        
    }
}
