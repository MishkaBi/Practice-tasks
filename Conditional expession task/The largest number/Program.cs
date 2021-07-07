using System;

namespace The_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("The 3rd Number is the greatest among three.");
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Three Numbers are the same");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("The 1st and 2nd Numbers are the same and greater than the 3rd number");
            }
            else if (num1 == num3)
            {
                Console.WriteLine("The 1st and 3nd Numbers are the same and greater than the 2nd number");
            }
            else if (num3 == num2)
            {
                Console.WriteLine("The 2nd and 3rd Numbers are the same and greater than the 1st number");
            }
        }
    }
}
