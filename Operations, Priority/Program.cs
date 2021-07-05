using System;

namespace Operations__Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            int n2 = 5;
            int result = n2 * 3 + 20 / 2 * n1--;
            //1) n2 * 3
            //2) 20 / 2
            //3) 2) * n1
            //4) 1) + 3)
            //5) n1--
            Console.WriteLine(result);
            
            int a = 100,
            b = 50,
            c = 10;
            int x = a >= 100 ? b : c / 10;
            // 1) c / 10
            // 2) a >= 100
            // 3) 2) ? b : 1)
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
