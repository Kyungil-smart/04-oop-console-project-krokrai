using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class GameScene : Scene
{
    public GameScene()
    {

    }

    Screen screen = new Screen();
    WareHouse resource = new WareHouse();

    string[] staticstics = new string[] 
    {
        "금  화 ∴ " ,
        "식  량 ∴ ",
        "나  무 ∴ ",
        "석  재 ∴ ",
        "광  석 ∴ ",
        "특수자원 ∴ ",
        "인  력 ∴ "
    };

    string[] destination =
    {
        "영지",
        ""
    };

    public override void Exit()
    {
        
    }

    public override void Start()
    {
        screen.RenderBasicMap();
        string s;
        for(int i = 0; i < staticstics.Length; i++)
        {
            s = staticstics[i];
            staticstics[i] = s.PadRight(11,'０');
        }
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTTOP,staticstics);

    }

    public override void Update()
    {
        
    }
}
