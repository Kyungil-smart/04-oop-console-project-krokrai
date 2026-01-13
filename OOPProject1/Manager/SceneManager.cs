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
        ChangeScene(_Scenes["통계"]);
        //ChangeScene(_Scenes["MainMenu"]);
    }

    static public void Update()
    {
        current.Update();
    }

    static public void AddScene()
    {
        _Scenes.Add("MainMenu", new MainMenuScene());
        _Scenes.Add("통계", new StatisSticsScene());
        _Scenes.Add("영지", new DominionScene());
        _Scenes.Add("군대", new Army());
        _Scenes.Add("탐사", new Expedition());
        _Scenes.Add("연구", new ResearchScene());
    }

    public static void ChangeScene(string s)
    {
        ChangeScene(_Scenes[s]);
    }

    public static void ChangeScene(Scene nextScene)
    {
        if (current == nextScene) return;

        current?.Exit();
        current = nextScene;
        current?.Start();
    }
}
