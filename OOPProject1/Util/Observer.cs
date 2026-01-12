using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Observer
{
    static List<(string, Action)> uis = new List<(string, Action)>();

    public static void SelecetInvoke(string s)
    {
        foreach((string ss, Action action) in uis)
        {
            if(s == ss)
            {
                action?.Invoke();
            }
        }
    }
    public static void Invoke()
    {
        foreach ((string ss, Action action) in uis)
        {
            action?.Invoke();
        }
    }

    public static void AddListener(string text, Action action)
    {
        uis.Add((text, action));
    }

    public static void Remove(string text)
    {
        uis.Remove((text, null));
    }

    public static void Reset()
    {
        uis.Clear();
    }
}
