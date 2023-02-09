using System.Drawing;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class Program
    {
        static DateTime date = DateTime.Now;
        static int menu = 1;
        static int position = 3, maxposition, minposition;
        static ConsoleKey key;
        static void Main()
        {
            int x = SubClass z;
            string y = SubClass.v;
            SubClass.DO(menu, position, x, y, maxposition, minposition, key, date);
        }

        public static void Menu(int z, string v)
        {
            Console.WriteLine("Добро пожаловать в кондитерскую!\r\nВыберите параметр торта\r\n-------------------\r\n  Форма торта\r\n  Размер торта\r\n  Вкус торта\r\n  Количество коржей\r\n  Глазурь\r\n  Декор\r\n  Конец заказа\r\n\r\n");
            Console.WriteLine($"Цена: {z}");
            Console.WriteLine($"Ваш торт: {v}");
        }
        public static int CursorPosition(int position, int maxposition, int minposition, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    position--;
                    if (position < minposition)
                    {
                        position = minposition;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    position++;
                    if (position > maxposition)
                    {
                        position = maxposition;
                    };
                    break;
            }
            return position;
        }

        public static void WriteCursor(int position)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
    }
}