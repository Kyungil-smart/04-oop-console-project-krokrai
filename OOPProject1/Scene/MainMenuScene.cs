using System;

namespace OOPProject1
{
    class MainMenuScene : Scene
    {
        Screen screen = new Screen();

        public MainMenuScene()
        {

        }

        string[] Menus = new string[3]
        { 
            "게임 시작",
            "크레딧",
            "게임 종료"
        };

        public override void Start()
        {
            if (isSceneFirstIn)
            {
                isSceneFirstIn = false;
            }
            Render();
            Update();
        }

        public override void Update()
        {
            screen.SelecteUp();
        }

        void Render()
        {
            screen.RenderBasicMap();
            screen.RenderRatengle(Screen.ScreenPosition.CENTER,Menus,false);
        }

        public override void Exit()
        {

        }
    }
}
