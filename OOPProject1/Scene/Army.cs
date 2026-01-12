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

    string[] armys = new string[3];

    public int conscript { get; private set; }
    public int knight { get; private set; }

    public override void Exit()
    {
        
    }

    public override void Start()
    {
        units = new Unit[2];
        units[0] = new Conscript("징집병", 1, 10, 10, 1, 2);
        units[1] = new Knight("기사", 50, 0, 1, 5, 10);

        //일단... 작동 시켜야한다...
        // 이 이전 모든 함수 재 작업 요망
        armys[0] = "종 류 ∴ 인 력 ∴ 광 물 ∴ 생산수 ∴ 전투력";
        for(int i = 1; i < armys.Length; i++)
        {
            armys[i] = units[i-1].name.PadRight(3) + " ∴ " + units[i-1].useHumanResource.TranstoString().PadLeft(3) + " ∴ " + units[i - 1].useOre.TranstoString().PadLeft(3) + " ∴ " + units[i - 1].modify.TranstoString().PadLeft(3) + " ∴ " + units[i-1].combatRate.TranstoString().PadLeft(3);
        }
        

        string s;
        if (isSceneFirstIn)
        {
            conscript = 10;
            screen.RenderBasicMap();
            screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);
            screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP, armys,true);
            Render();
        }
        
    }

    public override void Update()
    {
        
    }

    void Render()
    {
        
    }

    
}
