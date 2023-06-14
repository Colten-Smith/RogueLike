using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Clock
    {
        public void WaitSeconds(int timeToWait) //30
        {
            int time = DateTime.Now.Second; //30
            // (now < time + wait && > time) || now < time - 60 + wait 
            while((DateTime.Now.Second < time + timeToWait && DateTime.Now.Second >= time) || DateTime.Now.Second < time - 60 + timeToWait)
            {
            }
        }
        public void WaitFractionsOfASecond(int fraction)
        {
            int timeToWait = 1000 / fraction;
            int time = DateTime.Now.Millisecond;
            while ((DateTime.Now.Millisecond < time + timeToWait && DateTime.Now.Millisecond >= time) || DateTime.Now.Millisecond < time - 1000 + timeToWait)
            {
            }
        }
    }
}
