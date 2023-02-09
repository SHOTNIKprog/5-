using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class SubClass
    {
        static string[] forma = new string[5] { "  Круглый - 100;", "  Квадратный- 250;", "  Треугольный - 350;", "  Ромб - 700;", "  Звезда- 500;" };
        static string[] size = new string[5] { "  Маленький - 300;", "  Средний - 500;", "  Большой- 600;", "  Подарочный - 1000;", "  Свадебный - 1200;" };
        static string[] vkus = new string[5] { "  Клубничный - 300;", "  Малиновый - 400;", "  Шоколадный - 250;", "  Ореховый - 650;", "  Апельсиновый - 500;" };
        static string[] Kolvo_Korgey = new string[5] { "  Один - 100;", "  Два - 200;", "  Три - 300;", "  Четыре - 400;", "  Пять - 500;" };
        static string[] glazur = new string[5] { "  Шоколад - 200;", "  Крем - 200;", "  Бизе - 300;", "  Драже - 150;", "  Ягоды - 400;" };
        static string[] decor = new string[5] { "  Праздничный - 500;", "  Глазурный - 300;", "  Сироп - 200;", "  Карамель - 150;", "  Шоколад - 200;" };
        private static int cost;
        private static string text;
        public static int x = 0;
        public static string y = "";
        private static DateTime date;

        public static int DO(int menu, int position, int z, string v, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            maxposition = 9;
            minposition = 3;
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 1:
                        Program.Menu(z, v);
                        break;
                    case 2:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 3:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 4:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 5:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 6:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 7:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                }
                Program.WriteCursor(position);
                key = Console.ReadKey().Key;
                position = Program.CursorPosition(position, maxposition, minposition, key);
                if (key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                }
                switch (menu)
                {
                    case 1:
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 3:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 2;
                                        break;
                                    case 4:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 3;
                                        break;
                                    case 5:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 4;
                                        break;
                                    case 6:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 5;
                                        break;
                                    case 7:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 6;
                                        break;
                                    case 8:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 7;
                                        break;
                                    case 9:
                                        date = DateTime.Now;
                                        Console.Clear();
                                        Console.WriteLine("Заказ оформлен");
                                        File.AppendAllText("C:\\Users\\SHOTNIK\\Documents\\ConsoleApp13\\Заказы.txt", $"Время заказа {date}\r\n Цена: {z}\r\n Состав заказа: {v}\r\n");
                                        z = 0;
                                        v = "";
                                        SubClass.z = 0;
                                        SubClass.v = "";
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                Console.Clear();
                                check = false;
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            } while (check);
            return menu;
        }
        private static void SubMenu(int menu, ConsoleKey key, int position, int maxposition, int minposition)
        {
            cost = 0;
            text = "";
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 2:
                        Console.WriteLine(forma[0]);
                        Console.WriteLine(forma[1]);
                        Console.WriteLine(forma[2]);
                        Console.WriteLine(forma[3]);
                        Console.WriteLine(forma[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = forma[0];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = forma[1];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = forma[2];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = forma[3];
                                        cost = 400;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = forma[4];
                                        cost = 500;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 3;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(size[0]);
                        Console.WriteLine(size[1]);
                        Console.WriteLine(size[2]);
                        Console.WriteLine(size[3]);
                        Console.WriteLine(size[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = size[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = size[1];
                                        cost = 450;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = size[2];
                                        cost = 600;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = size[3];
                                        cost = 900;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = size[4];
                                        cost = 1200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 4;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine(vkus[0]);
                        Console.WriteLine(vkus[1]);
                        Console.WriteLine(vkus[2]);
                        Console.WriteLine(vkus[3]);
                        Console.WriteLine(vkus[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = vkus[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = vkus[1];
                                        cost = 400;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = vkus[2];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = vkus[3];
                                        cost = 600;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = vkus[4];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 5;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine(Kolvo_Korgey[0]);
                        Console.WriteLine(Kolvo_Korgey[1]);
                        Console.WriteLine(Kolvo_Korgey[2]);
                        Console.WriteLine(Kolvo_Korgey[3]);
                        Console.WriteLine(Kolvo_Korgey[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = Kolvo_Korgey[0];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = Kolvo_Korgey[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = Kolvo_Korgey[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = Kolvo_Korgey[3];
                                        cost = 400;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = Kolvo_Korgey[4];
                                        cost = 500;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 6;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine(glazur[0]);
                        Console.WriteLine(glazur[1]);
                        Console.WriteLine(glazur[2]);
                        Console.WriteLine(glazur[3]);
                        Console.WriteLine(glazur[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = glazur[0];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = glazur[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = glazur[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = glazur[3];
                                        cost = 150;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = glazur[4];
                                        cost = 400;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 7;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine(decor[0]);
                        Console.WriteLine(decor[1]);
                        Console.WriteLine(decor[2]);
                        Console.WriteLine(decor[3]);
                        Console.WriteLine(decor[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = decor[0];
                                        cost = 500;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = decor[1];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = decor[2];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = decor[3];
                                        cost = 150;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = decor[4];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 8;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, z, v, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                }
            } while (check);
        }
        private static int Cost()
        {
            z = z + cost;
            return z;
        }
        private static string Text()
        {
            v = v + text;
            return v;
        }
        private static void Returned(int menu, int position, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            Cost();
            Text();
            position = 3;
            Console.Clear();
            menu = 1;
            DO(menu, position, z:, v:, maxposition, minposition, key, date);
        }

    }
}
