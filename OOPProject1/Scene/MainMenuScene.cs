using System;

namespace OOPProject1
{
    class MainMenuScene : Scene
    {
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
                for (int i = 0; i < destination.Length; i++)
                {
                    screen.AddSelect(destination[i]);
                }
                Render();
            }
            Update();
        }

        void Select()
        {

        }

        public void Scene()
        {

        }

        void SelectTrans()
        {
            screen.SelecteTrans();
        }

        void SelectUp()
        {
            screen.SelecteUp();
        }

        void SelectDown()
        {
            screen.SelecteDown();
        }

        public override void Update()
        {
            switch (InputManager.currentKey)
            {
                case ConsoleKey.Tab:
                    SelectTrans();
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
            screen.RenderRatengle(Screen.ScreenPosition.CENTER,Menus,false);
        }

        public override void Exit()
        {
            screen = null;
        }
    }
}
