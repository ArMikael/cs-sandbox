using System;

namespace CS_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");


            Console.WriteLine("How old are you?");
            var age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can enter.");
            }
            else
            {
                Console.WriteLine("You are not allowed to enter");
            }

            PricesBook book = new PricesBook();
            book.AddPrice(99);
            book.AddPrice(77);

            PriceStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average price: " + stats.AveragePrice);
            Console.WriteLine("Lowest price: " + stats.LowestPrice);
            Console.WriteLine("Highest price: " + stats.HighestPrice);
        }
    }
}
