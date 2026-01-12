using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Army : Scene
{
    /*인력 1 당 징집병 10
     * 인력 5 당 기사 1
     * 
     * 징집병 50 = 기사 1
     * 
     * 전투력
     * 징집병 = 1
     * 기사 50 / 징집병 10명당 전투력 2 추가 증가 최대 10 증가
     */

    string[] armys =
    {
        "징집병 ∴",
        "기 사 ∴"
    };

    public int conscript { get; private set; }
    public int knight { get; private set; }

    public override void Exit()
    {
        
    }

    public override void Start()
    {
        if (isSceneFirstIn)
        {
            conscript = 10;
            
        }
        
    }

    public override void Update()
    {
        
    }

    void Render()
    {
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTTOP, armys);
    }

    
}
