using System;

namespace Exercise13
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

                for (int i = num; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("\nWould you like to input another number? (Yes/No, case sensitive)");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Thank you for your time. Goodbye!");


        }
    }
}
