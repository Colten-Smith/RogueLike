using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    static class Timer
    {
        public static void WaitSeconds(int timeToWait) //30
        {
            int time = DateTime.Now.Second; //30
            // (now < time + wait && > time) || now < time - 60 + wait 
            while ((DateTime.Now.Second < time + timeToWait && DateTime.Now.Second >= time) || DateTime.Now.Second < time - 60 + timeToWait)
            {
            }
        }
        public static void WaitFractionsOfASecond(int fraction)
        {
            int timeToWait = 1000 / fraction;
            int time = DateTime.Now.Millisecond;
            while ((DateTime.Now.Millisecond < time + timeToWait && DateTime.Now.Millisecond >= time) || DateTime.Now.Millisecond < time - 1000 + timeToWait)
            {
            }
        }
        public static DateTime GetTime()
        {
            return DateTime.Now;
        }
        public static int GetTime(bool inMilliseconds = false)
        {
            if (inMilliseconds)
            {
                return DateTime.Now.Millisecond;
            }
            return DateTime.Now.Second;
        }
        public static bool HasPassed(DateTime startTime, int timeToWait, bool inMilliseconds = false)
        {

            DateTime currentTime = DateTime.Now;
            if (inMilliseconds)
            {
                if (currentTime.Subtract(startTime).TotalSeconds / 1000 > timeToWait)
                {
                    return true;
                }
            }
            else
            {
                if (currentTime.Subtract(startTime).TotalSeconds > timeToWait)
                {
                    return true;
                }

            }
            return false;
            
        }
    }
}
