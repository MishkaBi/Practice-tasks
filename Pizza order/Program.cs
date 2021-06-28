using System;

namespace Pizza_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вибер1ть з якого т1ста буде складатись п1ца\n1. Бездр1жджове\n2. Др1жджове\n3. Листкове\n4. Чорне");

            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть яка начинка буде у п1ц1\n1. Ковбаса\n2. Курка\n3. Бекон\n4. Сир");

            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть який соус буде у п1ц1\n1. Кетчуп\n2. Майонез\n3. Тартар\n4. Сирний");

            int num3 = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть як1 додатков1 1нгред1єнти будуть у п1ц1\n1. Оливки\n2. Пом1дори\n3. Ананас\n4. Креветки");

            int num4 = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine($"Ваша п1ца");


            if (num1 == 1)
            {
                Console.WriteLine("Т1сто: бездр1жджове");
            }
            if (num1 == 2)
            {
                Console.WriteLine("Т1сто: др1жджове");
            }
            if (num1 == 3)
            {
                Console.WriteLine("Т1сто: листкове");
            }
            if (num1 == 4)
            {
                Console.WriteLine("Т1сто: чорне");
            }



            if (num2 == 1)
            {
                Console.WriteLine("Начинка: ковбаса");
            }
            if (num2 == 2)
            {
                Console.WriteLine("Начинка: курка");
            }
            if (num2 == 3)
            {
                Console.WriteLine("Начинка: бекон");
            }
            if (num2 == 4)
            {
                Console.WriteLine("Начинка: сир");
            }



            if (num3 == 1)
            {
                Console.WriteLine("Соус: кетчуп");
            }
            if (num3 == 2)
            {
                Console.WriteLine("Соус: майонез");
            }
            if (num3 == 3)
            {
                Console.WriteLine("Соус: тартар");
            }
            if (num3 == 4)
            {
                Console.WriteLine("Соус: сирний");
            }



            if (num4 == 1)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: оливки");
            }
            if (num4 == 2)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: пом1дори");
            }
            if (num4 == 3)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: ананас");
            }
            if (num4 == 4)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: креветки");
            }
        }
    }
}
