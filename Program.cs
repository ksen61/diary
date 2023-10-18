using System;
using проба;



DateTime tekdata;
while (true)
{
    tekdata = Menu.date;
    Console.WriteLine(Menu.date.ToString());
    foreach (Note i in Menu.za)
    {
        if (i.data.Date == tekdata.Date)
        {
            Console.WriteLine("  " + i.nazvanie);
            Menu.zametkiekran.Add(i);
        }
    }

    int position = Menu.Show(1, Menu.zametkiekran.Count);



    if (position == 1)
    {
        Console.Clear();
        Console.WriteLine(Menu.zametkiekran[0].nazvanie);
        Console.WriteLine(Menu.zametkiekran[0].opisanie);
        Console.WriteLine("Дата заметки:");
        Console.WriteLine(Menu.zametkiekran[0].data);
    }
    else if (position == 2)
    {
        Console.Clear();
        Console.WriteLine(Menu.zametkiekran[1].nazvanie);
        Console.WriteLine(Menu.zametkiekran[1].opisanie);
        Console.WriteLine("Дата заметки:");
        Console.WriteLine(Menu.zametkiekran[1].data);
    }
    Console.SetCursorPosition(0, 6);

    Console.WriteLine("Нажмите Enter, чтобы продолжить...");
    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    Console.Clear();
}
class Note
{
    public string nazvanie;
    public string opisanie;
    public DateTime data;
}