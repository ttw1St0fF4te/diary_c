using System.Runtime.InteropServices;
namespace diary_c
{
    internal class Data
    {
        public int day = 14;
        public int month = 10;
        public int year = 2023;
        public bool flag = false;
    }
    internal class Program
    {
        static void Main()
        {
            KeyInfo();
        }

        static void KeyInfo()
        {
            int pos = 1;
            ConsoleKeyInfo key;
            Data data = new Data();

            do
            {
                if (data.day <= 0)
                    data.day = 1;

                if (data.day >= 31)
                {
                    data.day = 1;
                    data.month++;
                    if (data.month >= 12)
                    {
                        data.month = 1;
                        data.year++;
                    }
                }
                Console.WriteLine($"Выбрана дата: {data.day}.{data.month}.{data.year}");
                if (data.day % 2 == 0)
                {
                    Console.WriteLine("  1. Прийти на пары.");
                    Console.WriteLine("  2. Остаться дома.");
                }
                else
                {
                    if (data.flag == true)
                    {
                        Console.WriteLine("  1. Убраться дома.");
                        Console.WriteLine("  2. Пойти гулять.");
                        data.flag = false;
                    }
                    else
                    {
                        Console.WriteLine("  На сегодня дел нет :)");
                        data.flag = true;
                    }
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != 1)
                {
                    Console.Clear();
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 2)
                {
                    Console.Clear();
                    pos++;
                }
                else
                {
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data.day--;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    data.day++;
                }
            }
            while (key.Key != ConsoleKey.Enter);

            if (data.day % 2 == 0 && pos == 1)
            {
                Console.Clear();
                Task();
                Console.Clear();
                Main();
            }
            else if (data.day % 2 == 0 && pos == 2)
            {
                Console.Clear();
                Task1();
                Console.Clear();
                Main();
            }
            else if (data.day % 2 != 0 && pos == 1 && data.flag == false)
            {
                Console.Clear();
                Task2();
                Console.Clear();
                Main();
            }
            else if (data.day % 2 != 0 && pos == 2 && data.flag == false)
            {
                Console.Clear();
                Task3();
                Console.Clear();
                Main();
            }
        }

        static void Task()
        {
            Data data = new Data();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Прийти на пары."); 
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Описание: С первой по пятую (ужас)");
                Console.WriteLine($"{data.day}.{data.month}.{data.year}");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
        static void Task1()
        {
            Data data = new Data();
            ConsoleKeyInfo key; 
            do
            {
                Console.WriteLine("Остаться дома.");
                Console.WriteLine("-------------------------------------------------------------------------"); 
                Console.WriteLine("Описание: Сделать чаек и играть в компек.");
                Console.WriteLine($"{data.day}.{data.month}.{data.year}");
                key = Console.ReadKey();
            } 
            while (key.Key != ConsoleKey.Escape);
        }
        static void Task2()
        {
            Data data = new Data();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Убраться дома.");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Описание: Переосилить внутреннего монстра и выбросить пакет от чипсов.");
                Console.WriteLine($"{data.day}.{data.month}.{data.year}");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
        static void Task3()
        {
            Data data = new Data();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Пойти гулять.");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Описание: Выйти из берлоги(комнаты) и убить злейшего врага(ассоциальность)");
                Console.WriteLine($"{data.day}.{data.month}.{data.year}");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}