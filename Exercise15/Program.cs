using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Yes";

            while (answer == "Yes")
            {
                Console.WriteLine("Please input a number:");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    Console.Write(Math.Pow(i, 3) + " ");
                }

                Console.WriteLine("\nWould you like to input another value? (Yes/No, case sensitive)");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Thank you for trying my program. Goodbye");
        }
    }
}
