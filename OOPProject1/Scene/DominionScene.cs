using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DominionScene : Scene
{
    string[] list =
    {
        "건물명 ∴ 필요량 ∴ 보유량",
        "농 장 ∴ ",
        "벌목장 ∴ ",
        "채석장 ∴ ",
        "광 산 ∴ ",
        "시 장 ∴ ",
        "연구소 ∴ ",
        "군부대 ∴ ",
        " 성  ∴ ",
        "탐험대 ∴ ",
    };

    public override void Exit()
    {
        screen = null;
    }

    public override void Start()
    {
        screen.RenderBasicMap();
        screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP,list,true);
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);

    }

    void Select()
    {

    }

    void SelectTrans()
    {
        screen.SelecteTrans();
    }

    void SelectUp()
    {
        screen.SelecteUp();
    }

    void SelectDown()
    {
        screen.SelecteDown();
    }

    public override void Update()
    {
        switch(InputManager.currentKey)
        {
            case ConsoleKey.Tab:
                SelectTrans();
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
