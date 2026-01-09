using System;
public static class StringUtils
{
    public static void ColorPrinter(this string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.ForegroundColor = color;
        Console.Write(s);
        Console.ResetColor();
    }

    public static void ColorPrinter(this char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.ForegroundColor = color;
        Console.Write(c);
        Console.ResetColor();
    }

    public static void ScreenPrinter(this string s, ConsoleColor color = ConsoleColor.Gray)
    {
        char[] c = s.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] == ' ')
                c[i] = '　';
        }
        for (int i = 0;i < c.Length; i++)
        {
            c[i].ColorPrinter(color);
        }
    }
    public static void ScreenPrinter(this char c, ConsoleColor color = ConsoleColor.Gray)
    {
        if (c == ' ')
            c = '　';
        c.ColorPrinter(color);
    }
}
