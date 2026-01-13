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
        Console.Clear();
    }

    public override void Start()
    {
        research = new ResearchTree();

        for (int i = 0; i < destination.Length; i++)
        {
            screen.AddSelect(destination[i]);
        }
        screen.RenderBasicMap();
        screen.RenderRatengle(Screen.ScreenPosition.LEFTTOP,research.Researchable(),true);
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
                screen.Selecte();
                break;
        }
    }
}