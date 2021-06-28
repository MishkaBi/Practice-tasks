using System;

namespace IO_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of person who has a birthday soon");
            string name = Console.ReadLine();


            Console.WriteLine("Enter birthday");
            DateTime now = DateTime.Now;
            string birthday1 = Console.ReadLine();
            var birthday = DateTime.Parse(birthday1);

            TimeSpan age = now - birthday;

            Console.WriteLine(age.TotalSeconds);


            Console.WriteLine("Enter a present");
            string present = Console.ReadLine();

            Console.WriteLine("Enter a giver");
            string nameOfGiver = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"{name} has a birthday soon!");

            Console.WriteLine($" Current age: {age}  \n Birthday: {birthday}  \n Present: {present} \n Giver: {nameOfGiver} ");
        }
    }
}
