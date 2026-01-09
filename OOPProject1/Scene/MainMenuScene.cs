using System;

namespace OOPProject1
{
    class MainMenuScene : Scene
    {
        string[] Menus = new string[3]
        { 
            "게임 시작",
            "크레딧",
            "게임 종료"
        };
        public MainMenuScene()
        {

        }

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
            
        }

        void Render()
        {
            Screen.RenderBasicMap();
            Screen.RenderRatengle(Screen.ScreenPosition.CENTER,Menus,false);
        }
        public override void Exit()
        {

        }
    }
}
