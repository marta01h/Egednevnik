using System;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static DateTime Time = DateTime.Now;
        static int Vse_dlua_menua = 0;
        static int Work = 2;
        static void Main(string[] args)
        {
            task a = new task()
            {
                Day = 6,
                name = "Выполнить домашние дела",
                opisanie = "Развернуто: пропылесосить, вынести мусор"
            };
            task.tasks.Add(a);
            task b = new task()
            {
                Day = 6,
                name = "Пойти на учебу в мпт",
                opisanie = "Развернуто: собрать рюкзак, незабыдь ключи"
            };
            task.tasks.Add(b);
            task c = new task()
            {
                Day = 6,
                name = "Сделать практику ОАиП",
                opisanie = "Развернуто: загрузить через gitbash код на сайт"
            };
            task.tasks.Add(c);
            task d = new task()
            {
                Day = 7,
                name = "Сделать тортик",
                opisanie = "Развернуто: подготовить индегредиенты"
            };
            task.tasks.Add(d);
            task e = new task()
            {
                Day = 8,
                name = "Свободное время для себя",
                opisanie = "Развернуто: расслабится перед телефизором, выпить коктейль"
            };
            task.tasks.Add(e);
            task f = new task()
            {
                Day = 8,
                name = "Магазин",
                opisanie = "Развернуто: купить всё необходимое для тортика"
            };
            task.tasks.Add(f);
            task g = new task()
            {
                Day = 9,
                name = "Клуб",
                opisanie = "Развернуто: сходить на бокс, отзаниматься 1 час"
            };
            task.tasks.Add(g);
            task h = new task()
            {
                Day = 9,
                name = "Маникюр",
                opisanie = "Развернуто: выделить время после учебы и сделать самой маникюр"
            };
            task.tasks.Add(h);
            task i = new task()
            {
                Day = 10,
                name = "Обед",
                opisanie = "Расвернуто: перекусить вкусным бананом и молоком"
            };
            task.tasks.Add(i);

            while (true)
            {
                Alfavite();
                Clavishka();
                Strelochechka();
            }
        }


        private static void Alfavite()
        {
            int mestniiyNomerok = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"ЗАметки по дате: {Time.AddDays(Vse_dlua_menua).Day}.{Time.AddDays(Vse_dlua_menua).Month}.{Time.AddDays(Vse_dlua_menua).Year}");
            foreach (var elementik in task.tasks)
            {
                if (elementik.Day == Time.AddDays(Vse_dlua_menua).Day)
                {
                    mestniiyNomerok++;
                    Console.SetCursorPosition(4, mestniiyNomerok + 1);
                    elementik.Number = mestniiyNomerok;
                    Console.Write($"{elementik.Number}.{elementik.name}\n");
                }
            }

        }
        private static void Clavishka()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    Vse_dlua_menua--;
                    break;
                case ConsoleKey.RightArrow:
                    Vse_dlua_menua++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Work < 3)
                    {
                        Work = 2;
                    }
                    else
                    {
                        Work--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Work > 3)
                    {
                        Work = 4;
                    }
                    else
                    {
                        Work++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int mestniiyNomerok = 0;
            Console.Clear();
            foreach (var elementik in task.tasks)
            {
                if (elementik.Day == Time.AddDays(Vse_dlua_menua).Day)
                {
                    mestniiyNomerok++;
                    elementik.Number = mestniiyNomerok;
                    if (mestniiyNomerok == Work - 1)
                    {
                        Console.Write($"  {elementik.name}\n");
                        Console.Write(" " + elementik.opisanie);
                    }
                }
            }
        }

        private static void Strelochechka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Work);
            Console.Write("->");
        }
    }
}