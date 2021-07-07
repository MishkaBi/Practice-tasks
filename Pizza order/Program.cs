using System;

namespace Pizza_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вибер1ть з якого т1ста буде складатись п1ца\n1. Бездр1жджове\n2. Др1жджове\n3. Листкове\n4. Чорне");
            string dough = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Вибер1ть яка начинка буде у п1ц1\n1. Ковбаса\n2. Курка\n3. Бекон\n4. Сир");
            string filling = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Вибер1ть який соус буде у п1ц1\n1. Кетчуп\n2. Майонез\n3. Тартар\n4. Сирний");
            string sauce = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Вибер1ть як1 додатков1 1нгред1єнти будуть у п1ц1\n1. Оливки\n2. Пом1дори\n3. Ананас\n4. Креветки");
            string additional = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Ваша п1ца");


            if (dough == "1")
            {
                Console.WriteLine("Т1сто: бездр1жджове");
            }
            else if (dough == "2")
            {
                Console.WriteLine("Т1сто: др1жджове");
            }
            else if (dough == "3")
            {
                Console.WriteLine("Т1сто: листкове");
            }
            else if (dough == "4")
            {
                Console.WriteLine("Т1сто: чорне");
            }
            else
            {
                Console.WriteLine("Т1сто: не вибране, повтор1ть спробу");
            }



            if (filling == "1")
            {
                Console.WriteLine("Начинка: ковбаса");
            }
            else if (filling == "2")
            {
                Console.WriteLine("Начинка: курка");
            }
            else if (filling == "3")
            {
                Console.WriteLine("Начинка: бекон");
            }
            else if (filling == "4")
            {
                Console.WriteLine("Начинка: сир");
            }
            else
            {
                Console.WriteLine("Начинка: не вибрана, повтор1ть спробу");
            }


            if (sauce == "1")
            {
                Console.WriteLine("Соус: кетчуп");
            }
            else if (sauce == "2")
            {
                Console.WriteLine("Соус: майонез");
            }
            else if (sauce == "3")
            {
                Console.WriteLine("Соус: тартар");
            }
            else if (sauce == "4")
            {
                Console.WriteLine("Соус: сирний");
            }
            else
            {
                Console.WriteLine("Соус: не вибраний, повтор1ть спробу");
            }


            if (additional == "1")
            {
                Console.WriteLine("Додатков1 1нгред1єнти: оливки");
            }
            else if (additional == "2")
            {
                Console.WriteLine("Додатков1 1нгред1єнти: пом1дори");
            }
            else if (additional == "3")
            {
                Console.WriteLine("Додатков1 1нгред1єнти: ананас");
            }
            else if (additional == "4")
            {
                Console.WriteLine("Додатков1 1нгред1єнти: креветки");
            }
            else
            {
                Console.WriteLine("Додатков1 1нгред1єнти: не вибран1, повтор1ть спробу");
            }
        }
    }
}
