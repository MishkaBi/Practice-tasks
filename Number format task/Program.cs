using System;

namespace Number_format_task
{
    class Program
    {

        static void Main(string[] args)
        {

            int num1 = 0xff;

            int num2 = 0177;

            Console.WriteLine($"number1 FF = {num1} \nnumber2 127 = {num2}\n");



            int a = num1 + num2;
            int b = num1 - num2;
            int c = num1 * num2;
            int d = num1 / num2;
            int e = num1 % num2;
            int f = num1-- + num2++;
            int g = num1 + (num1 - num2) * num1 / 2;

            Console.WriteLine($"{ a}\n{ b}\n{c}\n{d}\n{f}\n{g}");

        }
    }
}
