using System;

namespace Leap_year_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
