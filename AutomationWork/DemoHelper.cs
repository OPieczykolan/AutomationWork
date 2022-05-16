using System.Threading;

namespace AutomationWork
{
    internal static class DemoHelper
    {
        //Delay to slow down browser interactions for demo recording purposes
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
