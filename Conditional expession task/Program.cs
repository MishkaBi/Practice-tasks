using System;

namespace Conditional_expession_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year");
            }
            else
            {
                Console.WriteLine($"The year {year} isn't a leap year.");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
              if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three.");
                }
            }

            if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("The 2nd Number is the greatest among three.");
                }
            }

            if (num3 > num1)
            {
                if (num3 > num2)
                {
                    Console.WriteLine("The 3rd Number is the greatest among three.");
                }
            }

        }
    }
}
