using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class DominionScene : Scene
{
    Structure structure = new Structure();
    string[] list =
    {
        "필요량 ∴ 나 무 ∴ 석 재 ∴ 금 화 ∴ 인 력",
        "농 장",
        "벌목장",
        "채석장",
        "광 산",
        "시 장",
        "연구소",
        "군부대",
        " 성 ",
        "탐험대",
    };

    public override void Exit()
    {
        screen = null;
    }

    public override void Start()
    {

        for (int i = 0; i < destination.Length; i++)
        {
            screen.AddSelect(destination[i]);
        }
        
        for (int i = 1; i < list.Length; i++)
        {
            list[i] = list[i].PadRight(3) + " ∴ " + structure.list[i-1].Item1.TranstoString().PadLeft(3) + " ∴ " + structure.list[i - 1].Item2.TranstoString().PadLeft(3) + " ∴ " + structure.list[i - 1].Item3.TranstoString().PadLeft(3) + " ∴ " + structure.list[i - 1].Item4.TranstoString().PadLeft(3);
        }

        screen.RenderBasicMap();
        screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP,list,true);
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);
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
                structure.Construction( (Structure.Building) screen.Selecte());
                break;
        }
    }
}
