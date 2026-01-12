using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ResearchScene : Scene
{
    ResearchTree research;

    public override void Exit()
    {
        
    }

    public override void Start()
    {
        research = new ResearchTree();
        screen.RenderBasicMap();
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);
        screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP,research.Researchable());
    }

    public override void Update()
    {
        
    }
}