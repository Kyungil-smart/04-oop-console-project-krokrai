using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class InputManager
{
    static readonly ConsoleKey[] WhiteListKey =
    {
        ConsoleKey.UpArrow,
        ConsoleKey.DownArrow,
        ConsoleKey.LeftArrow,
        ConsoleKey.RightArrow,
        ConsoleKey.Enter,
        ConsoleKey.Escape,
        ConsoleKey.Clear,
        ConsoleKey.Tab,
    };

    public static ConsoleKey currentKey { get; private set; }

    public static void InputTracker()
    {
        ConsoleKey inKey = Console.ReadKey(true).Key;
        for (int i = 0; i < WhiteListKey.Length; i++)
        {
            if (WhiteListKey[i] == inKey)
            {
                currentKey = inKey;
                break;
            }
        }
    }
}
