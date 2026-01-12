using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Army : Scene
{
    /* 자원 소모
     * 인력 1 , 광물 2 당 징집병 10
     * 인력 5, 광물 10 당 기사 1
     * 
     * 전투력
     * 징집병 = 1
     * 기사 = 50 / 기사 한명당 징집병 50명 통제, 통제되는 동안 징집병 10당 전투력 2 증가
     */
    Unit[] units;

    string[] armys =
    {
        "종 류 ∴ 인력소모 ∴ 광물 소모 ∴ 생산수 ∴ 전투력",
        "징집병 ∴ ",
        "기 사 ∴ "
    };

    public int conscript { get; private set; }
    public int knight { get; private set; }

    public override void Exit()
    {
        
    }

    public override void Start()
    {
        string s;
        if (isSceneFirstIn)
        {
            for (int i = 0; i < armys.Length; i++)
            {
                s = armys[i];
                armys[i] = s.PadRight(9, '０');
            }
            conscript = 10;
            screen.RenderBasicMap();
            screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);
            screen.RenderRatengle(Screen.ScreenPosition.RIGHTTOP, armys);
            screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP, null,true);
            Render();
        }
        units[0] = new Conscript("징집병", 1, 10, 10, 1, 2);
        units[1] = new Knight("기사", 50, 0, 1, 5, 10);
    }

    public override void Update()
    {
        
    }

    void Render()
    {
        

    }

    
}
