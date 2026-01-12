using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;

class Screen
{
    public const int screenMaxHeight = 30;
    public const int screenMaxWidth = 50;

    List<(string, Action)> selecte = new List<(string, Action)>();
    List<List<(string, Action)>> listSelecte = new List<List<(string, Action)>>();

    List<(string[], Pos, Pos)> listScreenStrings = new List<(string[], Pos, Pos)>();

    public int CurruntIndex { get; private set; } = 1;
    public int CurruntArrayIndex { get; private set; } = 0;

    public enum ScreenPosition
    {
        LEFTCENTER, RIGHTCENTER, CENTERTOP, CENTERBOTTOM, CENTER, LEFTTOP, RIGHTTOP, LEFTBOTTOM, RIGHTBOTTOM
    }

    char[,] BasicScreen = new char[screenMaxHeight, screenMaxWidth]
            {
                { '◎','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','◎'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                {'｜','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','　','｜'},
                { '◎','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','ㅡ','◎'}
            };


    public void RenderBasicMap()
    {
        for (int i = 0; i < screenMaxHeight; i++)
        {
            for (int j = 0; j < screenMaxWidth; j++)
            {
                BasicScreen[i, j].ColorPrinter();
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(0, 0);
    }

    /*public void RenderRatengleForUnits(ScreenPosition pos, Unit unit)
    {
        if (unit == null)
        {
            Debug.AddLog("Renderer에 null 값을 갖는 Unit을 넣을 수 없습니다.", true);
        }

        Pos p1 = new Pos(0,0);
        Pos p2 = PosSelecter(pos,p1);

        ChoiceRenderer(p1,p2);
    }*/

    public void RenderRatengle(ScreenPosition pos,string[] s , bool isChoice = false)
    {
        if (s == null)
        {
            Debug.AddLog("Rendering NULL을 포함 시킬 수 없습니다.", true);
            return;
        }

        string a = s[0];
        int maxLength = a.Length;

        for (int i = 1; i < s.Length; i++)
        {
            if (maxLength < s[i].Length)
                maxLength = s[i].Length;
        }

        for ( int i = 0; i < s.Length; i++)
        {
            a = s[i];
            if (isChoice)
            {
                selecte.Add((a,null)); // 반드시 null을 수정할 것
            }
            s[i] = a.PadRight(maxLength);
        }

        Pos p1 = new Pos(maxLength + 2, s.Length + 2);

        Pos p2 = PosSelecter(pos,p1);
        listScreenStrings.Add((s, p1, p2));
        if (isChoice)
        {
            listSelecte.Add(selecte);
            ChoiceRenderer(p1, p2, s);
        }
        else
            Renderer(p1, p2, s);
    }

    Pos PosSelecter(ScreenPosition pos, Pos p1)
    {
        Pos p2;
        switch (pos)
        {
            case ScreenPosition.LEFTCENTER:
                return p2 = new Pos(0, screenMaxHeight / 2 - p1.Y / 2);
            case ScreenPosition.LEFTTOP:
                return p2 = new Pos(0, 0);
            case ScreenPosition.LEFTBOTTOM:
                return p2 = new Pos(0, screenMaxHeight - p1.Y);
            case ScreenPosition.CENTER:
                return p2 = new Pos(screenMaxWidth / 2, screenMaxHeight / 2) - (p1 / 2);
            case ScreenPosition.CENTERTOP:
                return p2 = new Pos(screenMaxWidth / 2 - p1.X / 2, 0);
            case ScreenPosition.CENTERBOTTOM:
                return p2 = new Pos(screenMaxWidth / 2 - p1.X / 2, screenMaxHeight - p1.Y);
            case ScreenPosition.RIGHTCENTER:
                return p2 = new Pos(screenMaxWidth - p1.X, screenMaxHeight / 2 - p1.Y / 2);
            case ScreenPosition.RIGHTTOP:
                return p2 = new Pos(screenMaxWidth - p1.X, 0);
            case ScreenPosition.RIGHTBOTTOM:
                return p2 = new Pos(screenMaxWidth - p1.X, screenMaxHeight - p1.Y);
            default:
                return p2 = new Pos(0, 0);
        }
    }

    public void AddSelect(string s, Action action)
    {
        selecte.Add((s, action));
    }

    public void SelecteTrans()
    {
        if (listSelecte.Count <= 0) return;
        CurruntArrayIndex++;
        if (CurruntArrayIndex >= listScreenStrings.Count) CurruntArrayIndex = 0;
        CurruntIndex = 1;
        ChoiceRenderer(listScreenStrings[CurruntArrayIndex].Item2, listScreenStrings[CurruntArrayIndex].Item3, listScreenStrings[CurruntArrayIndex].Item1);
    }

    public void Selecte()
    {
        listSelecte[CurruntArrayIndex][CurruntIndex].Item2?.Invoke();
    }

    public void SelecteUp()
    {
        if(CurruntIndex == 1) return;
        CurruntIndex--;
        ChoiceRenderer(listScreenStrings[CurruntArrayIndex].Item2, listScreenStrings[CurruntArrayIndex].Item3, listScreenStrings[CurruntArrayIndex].Item1);
    }

    public void SelecteDown()
    {
        if (CurruntIndex >= listScreenStrings[CurruntArrayIndex].Item1.Length - 1) return;
        CurruntIndex++;
        ChoiceRenderer(listScreenStrings[CurruntArrayIndex].Item2, listScreenStrings[CurruntArrayIndex].Item3, listScreenStrings[CurruntArrayIndex].Item1);
    }

    void Renderer(Pos p1, Pos p2, string[] s)
    {
        string a;
        for (int i = 0;i < p1.Y;i++)
        {
            Console.SetCursorPosition(p2.X * 2, p2.Y + i);
            for (int j = 0;j < p1.X;j++)
            {
                if (i == 0 || i == p1.Y - 1)
                {
                    if (j == 0 || j == p1.X - 1)
                    {
                        Console.Write("◎");
                    }
                    else
                    {
                        Console.Write("ㅡ");
                    }
                }
                else if (i != 0 && (j == 0 || j == p1.X - 1))
                {
                    Console.Write("｜");
                }
                else if (j > 0 )
                {
                    a = s[i - 1];
                    a[j - 1].ScreenPrinter();
                }
                else
                {
                    Console.Write("　");
                }
                
            }
        }
    }

    void ChoiceRenderer(Pos p1, Pos p2,string[] s)
    {
        string a;
        for (int i = 0; i < p1.Y; i++)
        {
            Console.SetCursorPosition(p2.X * 2, p2.Y + i);
            for (int j = 0; j < p1.X; j++)
            {
                if (i == 0 || i == p1.Y - 1)
                {
                    if (j == 0 || j == p1.X - 1)
                    {
                        Console.Write("◎");
                    }
                    else
                    {
                        Console.Write("ㅡ");
                    }
                }
                else if (i != 0 && (j == 0 || j == p1.X - 1))
                {
                    Console.Write("｜");
                }
                else if (j > 0)
                {
                    a = s[i - 1];
                    if (CurruntIndex == i - 1)
                        a[j - 1].ScreenPrinter(ConsoleColor.Green);
                    else
                        a[j - 1].ScreenPrinter();
                }
                else
                {
                    Console.Write("　");
                }

            }
        }
    }
}