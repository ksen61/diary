using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проба
{
    internal class Menu
    {
        static Note a = new Note()
        {
            nazvanie = "Покушать",
            opisanie = "Описание: съесть два бутерброда с колбасой",
            data = new DateTime(2023, 10, 17)
        };
        static Note b = new Note()
        {
            nazvanie = "Сходить на пары",
            opisanie = "Описание: с первой по четвертую",
            data = new DateTime(2023, 10, 17)
        };
        static Note s = new Note()
        {
            nazvanie = "Убраться дома",
            opisanie = "Описание: пропылесосить",
            data = new DateTime(2023, 10, 18)
        };
        static Note d = new Note()
        {
            nazvanie = "Сделать уроки",
            opisanie = "Описание: сделать дискретную матемактику и философию",
            data = new DateTime(2023, 10, 18)
        };
        static Note e = new Note()
        {
            nazvanie = "Погулять с собакой",
            opisanie = "Описание: выйти на улицу",
            data = new DateTime(2023, 10, 19)
        };
        static Note f = new Note()
        {
            nazvanie = "Приготовить поесть",
            opisanie = "Описание: сварить макороны",
            data = new DateTime(2023, 10, 19)
        };
        public static Note[] za = { a, b, s, d, e, f };
        public static List<Note> zametkiekran = new List<Note>();
        public static DateTime date = DateTime.Now;
        public static int Show(int minStrelochka, int maxStrelochka)
        {
            ConsoleKeyInfo key;
            int position = 1;
            date = DateTime.Now;

            do
            {

                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && position != minStrelochka)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != maxStrelochka)
                {
                    position++;
                }
                ChangeData(key);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
        public static void ChangeData(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.RightArrow)
            {
                Menu.zametkiekran.Clear();
                Console.SetCursorPosition(0, 0);
                date = date.AddDays(1);
                Console.Clear();
                Console.WriteLine(date.ToString());
                foreach (Note i in Menu.za)
                {
                    if (i.data.Date == date.Date)
                    {
                        Console.WriteLine("  " + i.nazvanie);
                        Menu.zametkiekran.Add(i);
                    }
                }
            }
            else if (info.Key == ConsoleKey.LeftArrow)
            {
                Menu.zametkiekran.Clear();
                Console.SetCursorPosition(0, 0);
                date = date.AddDays(-1);
                Console.Clear();
                Console.WriteLine(date.ToString());
                foreach (Note i in Menu.za)
                {
                    if (i.data.Date == date.Date)
                    {
                        Console.WriteLine("  " + i.nazvanie);
                        Menu.zametkiekran.Add(i);
                    }
                }
            }


        }
    }
}
