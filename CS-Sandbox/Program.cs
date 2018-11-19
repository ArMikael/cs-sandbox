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

            GradesBook book = new GradesBook();
            book.AddGrade(99);
            book.AddGrade(77);

            // GradeStatistics stats = book.getAverage();
        }
    }
}
