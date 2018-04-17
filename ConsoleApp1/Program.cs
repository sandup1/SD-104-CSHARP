using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double hits = Int32.Parse(Console.ReadLine());
            double bats = Int32.Parse(Console.ReadLine());

            string player = Console.ReadLine();

            double Average = hits / bats;
            Console.WriteLine(Average);

        }

    }
}
