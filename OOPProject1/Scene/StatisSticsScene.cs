using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class StatisSticsScene : Scene
{
    public StatisSticsScene()
    {

    }

    WareHouse resource = new WareHouse();

    string[] staticstics = new string[] 
    {
        "자  원 ∴ 소모량 ∴ 생산량 ∴ 구 매 ∴ 판 매",
        "금  화" ,
        "식  량",
        "나  무",
        "석  재",
        "광  석",
        "특수자원",
        "인  력"
    };

    public override void Exit()
    {
        Console.Clear();
    }

    public override void Start()
    {
        screen.RenderBasicMap();

        for (int i = 1; i < staticstics.Length; i++)
        {
            staticstics[i] = staticstics[i].PadRight(4) + " ∴ " + 10.TranstoString().PadLeft(3) + " ∴ " + 10.TranstoString().PadLeft(3) + " ∴ " + 10.TranstoString().PadLeft(3) + " ∴ " + 10.TranstoString().PadLeft(3);
        }

        /*
        string s;
         for(int i = 0; i < staticstics.Length; i++)
        {
            s = staticstics[i];
            staticstics[i] = s.PadRight(11,'０');
        }*/
        for (int i = 0; i < destination.Length; i++)
        {
            screen.AddSelect(destination[i]);
        }
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTTOP,staticstics, true);
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination,true);
    }

    public override void Update()
    {
        switch (InputManager.currentKey)
        {
            case ConsoleKey.Tab:
                screen.SelecteTrans();
                break;
            case ConsoleKey.UpArrow:
                screen.SelecteUp();
                break;
            case ConsoleKey.DownArrow:
                screen.SelecteDown();
                break;
            case ConsoleKey.Enter:
                screen.Selecte();
                break;
        }
    }
}
