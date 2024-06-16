using System;
using System.Drawing;

class MainClass
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();
        Echo(str, -1);
        Console.ReadKey();
    }

    static void Echo(string phrase, int i)
    {
        if (phrase.Length > 2)
        {
            phrase = phrase.Remove(0, 2);
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Convert.ToString(Colour(ref i)));
            Console.WriteLine("..." + phrase);
            Echo(phrase, i);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    private static Color Colour(ref int i)
    {
        if (i > Enum.GetNames(typeof(Color)).Length-2) i = -1;
        i++;
        return (Color)i;
    }
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Magenta,
        Cyan,
        White
    }
}
