using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Pos
{
    public int X;
    public int Y;

    public Pos(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Pos Up = new Pos(0, -1);
    public static Pos Down = new Pos(0, 1);
    public static Pos Left = new Pos(-1, 0);
    public static Pos Right = new Pos(1, 0);

    public static Pos operator +(Pos p1, Pos p2) => new Pos(p1.X + p2.X, p1.Y + p2.Y);
    public static Pos operator -(Pos p1, Pos p2) => new Pos(p1.X - p2.X, p1.Y - p2.Y);
    public static Pos operator *(Pos p1, Pos p2) => new Pos(p1.X * p2.X, p1.Y * p2.Y);
    public static Pos operator *(Pos p1, int num) => new Pos(p1.X * num, p1.Y * num);
    public static Pos operator /(Pos p1, Pos p2) => new Pos(p1.X / p2.X, p1.Y / p2.Y);
    public static Pos operator /(Pos p1, int num) => new Pos(p1.X / num, p1.Y / num);
    public static Pos operator %(Pos p1, Pos p2) => new Pos(p1.X % p2.X, p1.Y % p2.Y);
    public static Pos operator %(Pos p1, int num) => new Pos(p1.X % num, p1.Y % num);
}