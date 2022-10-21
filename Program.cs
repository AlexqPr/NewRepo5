using System;

namespace Practice4
{
    internal class Program
    {
        static void Main()
        {
            DATA();
        
        }
        static void DATA()
        {
            Console.Clear();
            int days = 0;

            DateTime newDATA;


            DateTime aDateTime = DateTime.Now;
            Console.WriteLine("Выбрана дата: \n" + aDateTime);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    days++;
                    DateTime newTime = aDateTime.AddDays(days);
                    Console.WriteLine("Выбрана дата: \n" + newTime);

                }
                // Добавить 1 день
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    days--;
                    DateTime newTime = aDateTime.AddDays(days);
                    Console.WriteLine("Выбрана дата: \n" + newTime);


                }

                if (days == 2)
                {
                    Console.WriteLine("->1.Придти на пары");
                    Console.WriteLine("  2.Сходить в гараж");
                    ConsoleKeyInfo key3;
                    key3 = key;


                    if (key3.Key == ConsoleKey.Enter)
                    {
                        newDATA = aDateTime.AddDays(days);
                        Vibor(newDATA);

                    }

                }
                if (days == 5)
                {
                    Console.WriteLine("->1.Помыться");
                    Console.WriteLine("  2.Сходить в магазин");
                    ConsoleKeyInfo key3;
                    key3 = key;

                    if (key3.Key == ConsoleKey.Enter)
                    {
                        newDATA = aDateTime.AddDays(days);
                        Vibor2(newDATA);
                    }
                }
                if (days == 6)
                {
                    Console.WriteLine("->Поиграть за компом");
                    ConsoleKeyInfo key3;
                    key3 = key;
                    if (key3.Key == ConsoleKey.Enter)
                    {
                        newDATA = aDateTime.AddDays(days);
                        Vibor3(newDATA);
                    }
                }
                if (days == 7)
                {
                    Console.WriteLine("->1. Заработать денег");
                    Console.WriteLine("  2. Найти работу");
                    ConsoleKeyInfo key3;
                    key3 = key;
                    if (key3.Key == ConsoleKey.Enter)
                    {
                        newDATA = aDateTime.AddDays(days);
                        Vibor4(newDATA);
                    }
                }
                if (days == 8)
                {
                    Console.WriteLine("->Сделать практическую по C#");
                    ConsoleKeyInfo key3;
                    key3 = key;
                    if (key3.Key == ConsoleKey.Enter)
                    {
                        newDATA = aDateTime.AddDays(days);

                        Vibor5(newDATA);
                    }
                }

                key = Console.ReadKey();

            }

            Environment.Exit(0);

        }

        static void Vibor(DateTime newDATA2)
        {
            int position = 1;
            Console.Clear();
            Console.WriteLine("Ваши дела на :" + newDATA2);
            Console.WriteLine("  1. Придти на пары");
            Console.WriteLine("  2. Сходить в гараж");

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            while (key2.Key != ConsoleKey.Escape)
            {

                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key == ConsoleKey.UpArrow)
                    {
                        position--;// position = position - 1

                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position++;// position = position + 1

                    }

                    if (position < 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    if (position > 2)
                    {
                        position = 2;
                        Console.SetCursorPosition(0, position);

                    }

                    Console.Clear();
                    Console.WriteLine("Ваши дела на :" + newDATA2);
                    Console.WriteLine("  1. Придти на пары");
                    Console.WriteLine("  2. Сходить в гараж");

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                }

                if (position == 1)
                {

                    Dela1(key2, newDATA2);

                }
                if (position == 2)
                {

                    Dela2(key2, newDATA2);

                }

            }
            DATA();

        }

        static void Vibor2(DateTime newDATA2)
        {
            int position = 1;
            Console.Clear();
            Console.WriteLine("Ваши дела на :" + newDATA2);
            Console.WriteLine("  1. Помыться");
            Console.WriteLine("  2. Сходить в магазин");

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
             while (key2.Key != ConsoleKey.Escape)
            {

                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key ==
                    ConsoleKey.UpArrow)
                    {
                        position--;// position = position - 1

                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position++;// position = position + 1

                    }

                    if (position < 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    if (position > 2)
                    {
                        position = 2;
                        Console.SetCursorPosition(0, position);

                    }

                    Console.Clear();
                    Console.WriteLine("Ваши дела на :" + newDATA2);
                    Console.WriteLine("  1. Помыться");
                    Console.WriteLine("  2. Сходить в магазин");

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                }

                if (position == 1)
                {

                    Dela3(key2, newDATA2);


                }
                if (position == 2)
                {
                    Dela4(key2, newDATA2);

                }

            }
            DATA();


        }
        static void Vibor3(DateTime newDATA2)
        {
            int position = 1;
            Console.Clear();
            Console.WriteLine("Ваши дело на :" + newDATA2);
            Console.WriteLine("  1. Поиграть за компом");


            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            while (key2.Key != ConsoleKey.Escape)
            {

                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key ==
                    ConsoleKey.UpArrow)
                    {
                        position--;// position = position - 1

                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position++;// position = position + 1

                    }

                    if (position < 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    if (position > 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    Console.Clear();
                    Console.WriteLine("Ваши дело на :" + newDATA2);
                    Console.WriteLine("  1. Поиграть за компом");


                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                }

                if (position == 1)
                {

                    Dela5(key2, newDATA2);

                }

            }
            DATA();
        }



        static void Vibor4(DateTime newDATA2)
        {
            int position = 1;
            Console.Clear();
            Console.WriteLine("Ваши дела на :" + newDATA2);
            Console.WriteLine("  1. Заработать денег");
            Console.WriteLine("  2. Найти работу");

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            while (key2.Key != ConsoleKey.Escape)
            {

                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key ==
                    ConsoleKey.UpArrow)
                    {
                        position--;// position = position - 1

                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position++;// position = position + 1

                    }

                    if (position < 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    if (position > 2)
                    {
                        position = 2;
                        Console.SetCursorPosition(0, position);

                    }

                    Console.Clear();
                    Console.WriteLine("Ваши дела на :" + newDATA2);
                    Console.WriteLine("  1. Заработать денег");
                    Console.WriteLine("  2. Найти работу");

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                }

                if (position == 1)
                {

                    Dela6(key2, newDATA2);

                }

                if (position == 2)
                {
                    Dela7(key2, newDATA2);
                }

            }
            DATA();
        }

        static void Vibor5(DateTime newDATA2)
        {
            int position = 1;
            Console.Clear();
            Console.WriteLine("Ваши дело на :" + newDATA2);
            Console.WriteLine("  Сделать практическую по C#");

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            while (key2.Key != ConsoleKey.Escape)
            {

                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key ==
                    ConsoleKey.UpArrow)
                    {
                        position--;// position = position - 1

                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position++;// position = position + 1

                    }

                    if (position < 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    if (position > 1)
                    {
                        position = 1;
                        Console.SetCursorPosition(0, position);

                    }

                    Console.Clear();
                    Console.WriteLine("Ваши дело на :" + newDATA2);
                    Console.WriteLine("  Сделать практическую по C#");

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                }

                if (position == 1)
                {

                    Dela8(key2, newDATA2);

                }

            }
            DATA();
        }

        static void Dela1(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Придти на пары");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nПсихолоигя общения\nФизкультура\nОсновы алгортимизации и программирования");
                Console.WriteLine("Дата: " + newDATA3);
                
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor(newDATA3);
                }
            }
        }

        static void Dela2(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Сходить в гараж");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nПочинить машину\nВзять гаечный ключ на 8\nДико погачитсья");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor(newDATA3);
                }
            }
        }
        static void Dela3(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Помыться");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nПомытсья под горячи душем\nОблить себя мылом\nИ сделать что-то еще по желанию");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor2(newDATA3);
                }
            }
        }
        static void Dela4(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Сходить в магазин");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nКупить хлеба\nДать деньги продавцу\nИли же просто слинять");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor2(newDATA3);
                }
            }
        }
        static void Dela5(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Поиграть за компом");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nЗапустить стрим\nАпнуть 10 лвл\nПоднять деньги на партнерке");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor3(newDATA3);
                }
            }
        }

        static void Dela6(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Заработать денег");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nЗаписаться на курсы инфоциганства\nПрогореть\nНайти нормальную работу");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor4(newDATA3);
                }
            }
        }

        static void Dela7(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Найти работу");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nСделать топовое резюме\nРазместить его\nПойти работать в Вкусно и точка");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor4(newDATA3);
                }
            }
        }

        static void Dela8(ConsoleKeyInfo key2, DateTime newDATA3)
        {
            while (key2.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Сделать практическую по C#");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Описание:\nПонять логику программы\nПокодить\nИсправить баги");
                Console.WriteLine("Дата: " + newDATA3);
                key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.Escape)
                {
                    Vibor5(newDATA3);
                }
            }
        }

    }
}