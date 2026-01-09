using System;
using System.Collections.Generic;
static class Debug
{
    private static List<(string,bool)> logs = new List<(string, bool)>();

    public static void AddLog(string s, bool isWarning)
    {
        logs.Add((s, isWarning));
        
    }

    public static void PrintLog()
    {
        foreach((string, bool) s in logs)
        {
            switch (s.Item2)
            {
                case true:
                    s.Item1.ColorPrinter(ConsoleColor.Yellow);
                    break;
                case false:
                    s.Item1.ColorPrinter();
                    break;
            }
        }
    }
}
