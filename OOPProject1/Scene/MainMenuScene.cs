using System;

namespace OOPProject1
{
    class MainMenuScene : Scene
    {
        public MainMenuScene()
        {

        }

        string[] Menus = new string[4]
        { 
            "이름 없는 시뮬레이터",
            "   게임 시작",
            "   크레딧",
            "   게임 종료"
        };

        public override void Start()
        {
            if (isSceneFirstIn)
            {
                isSceneFirstIn = false;
                for (int i = 0; i < destination.Length; i++)
                {
                    screen.AddSelect(destination[i]);
                }
                Render();
            }
            Update();
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

        void Render()
        {
            screen.RenderBasicMap();
            screen.RenderRatengle(Screen.ScreenPosition.CENTER,Menus,true);
        }

        public override void Exit()
        {
            Console.Clear();
        }
    }
}
