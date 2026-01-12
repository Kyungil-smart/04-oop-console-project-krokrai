using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

static class GameManager
{
    private const int maxFrame = 1000 / 60;
    private static DateTime time = DateTime.Now;
    private static int last;
    private static int now;

    public static void Start()
    {
        last = time.Millisecond + maxFrame;
        Run();
    }

    public static void Run()
    {
        SceneManager.Start();
        while(true)
        {
            InputManager.InputTracker();
            SceneManager.Update();
            

            FrameLoader();
        }
    }

    private static void FrameLoader()
    {
        time = DateTime.Now;
        now = time.Millisecond;
        last = now - last < 0 ? (now - last) * -1 : now - last;
        Thread.Sleep(last);
        time = DateTime.Now;
        last = time.Millisecond + maxFrame;
    }
}
