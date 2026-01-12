using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Expedition : Scene
{
    public override void Exit()
    {
        
    }

    public override void Start()
    {
        screen.RenderRatengle(Screen.ScreenPosition.RIGHTCENTER, destination, true);
    }

    public override void Update()
    {
        
    }
}
