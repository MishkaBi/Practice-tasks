using System;

namespace Pizza_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вибер1ть з якого т1ста буде складатись п1ца\n1. Бездр1жджове\n2. Др1жджове\n3. Листкове\n4. Чорне");

            int dough = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть яка начинка буде у п1ц1\n1. Ковбаса\n2. Курка\n3. Бекон\n4. Сир");

            int filling = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть який соус буде у п1ц1\n1. Кетчуп\n2. Майонез\n3. Тартар\n4. Сирний");

            int sauce = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine("Вибер1ть як1 додатков1 1нгред1єнти будуть у п1ц1\n1. Оливки\n2. Пом1дори\n3. Ананас\n4. Креветки");

            int additional = Convert.ToInt32(Console.ReadLine());


            Console.Clear();


            Console.WriteLine($"Ваша п1ца");


            if (dough == 1)
            {
                Console.WriteLine("Т1сто: бездр1жджове");
            }
            if (dough == 2)
            {
                Console.WriteLine("Т1сто: др1жджове");
            }
            if (dough == 3)
            {
                Console.WriteLine("Т1сто: листкове");
            }
            if (dough == 4)
            {
                Console.WriteLine("Т1сто: чорне");
            }
            if (dough > 4)
            {
                Console.WriteLine("Тісто: не вибране");
            }
            if (dough < 1)
            {
                Console.WriteLine("Тісто: не вибране");
            }


            if (filling == 1)
            {
                Console.WriteLine("Начинка: ковбаса");
            }
            if (filling == 2)
            {
                Console.WriteLine("Начинка: курка");
            }
            if (filling == 3)
            {
                Console.WriteLine("Начинка: бекон");
            }
            if (filling == 4)
            {
                Console.WriteLine("Начинка: сир");
            }
            if (filling > 4)
            {
                Console.WriteLine("Начинка: не вибрана");
            }
            if (filling < 1)
            {
                Console.WriteLine("Начинка: не вибрана");
            }



            if (sauce == 1)
            {
                Console.WriteLine("Соус: кетчуп");
            }
            if (sauce == 2)
            {
                Console.WriteLine("Соус: майонез");
            }
            if (sauce == 3)
            {
                Console.WriteLine("Соус: тартар");
            }
            if (sauce == 4)
            {
                Console.WriteLine("Соус: сирний");
            }
            if (sauce > 4)
            {
                Console.WriteLine("Соус: не вибраний");
            }
            if (sauce < 1)
            {
                Console.WriteLine("Соус: не вибраний");
            }



            if (additional == 1)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: оливки");
            }
            if (additional == 2)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: пом1дори");
            }
            if (additional == 3)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: ананас");
            }
            if (additional == 4)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: креветки");
            }
            if (additional > 4)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: не вибран1");
            }
            if (additional < 1)
            {
                Console.WriteLine("Додатков1 1нгред1єнти: не вибран1");
            }
        }
    }
}
