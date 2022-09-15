using System;

namespace PerfectNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("Enter the Number : ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");

            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }
    }
}
