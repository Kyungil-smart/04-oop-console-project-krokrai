using OOPProject1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

static class SceneManager
{
    private static Dictionary<string, Scene> _Scenes;
    private static Scene current;

    static public void Start()
    {
        _Scenes = new Dictionary<string, Scene>();
        AddScene();
        ChangeScene(_Scenes["DominionScene"]);
        //ChangeScene(_Scenes["MainMenu"]);
    }

    static public void Update()
    {
        current.Update();
    }

    static public void AddScene()
    {
        _Scenes.Add("MainMenu", new MainMenuScene());
        _Scenes.Add("GameScene", new StatisSticsScene());
        _Scenes.Add("DominionScene", new DominionScene());
    }

    public static void ChangeScene(Scene nextScene)
    {
        if (current == nextScene) return;

        current?.Exit();
        current = nextScene;
        current.Start();
    }
}
