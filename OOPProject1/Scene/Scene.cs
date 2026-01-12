using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

abstract class Scene
{
    protected Screen screen = new Screen();
    protected string[] destination =
    {
        "통계",
        "영지",
        "군대",
        "탐사",
        "연구",
        "알현",
        "마감",
    };

    protected bool isSceneFirstIn = true;
    /// <summary>
    /// Scene 최초 진입 시 호출될 함수
    /// </summary>
    public abstract void Start();

    /// <summary>
    /// Scene 유지되는 동안 반복될 함수
    /// </summary>
    public abstract void Update();


    /// <summary>
    /// Scene 종료시 호출될 함수
    /// </summary>
    public abstract void Exit();
}
