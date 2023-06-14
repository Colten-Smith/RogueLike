using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class TestClass
    {
        public void Test()
        {
            Room room = new Room(44, 22);
            room.AddDoor("12|24");
        }
        public void ScreenSaver()
        {
            int x = 131;
            int y = 1;
            bool xshrink = true;
            bool yshrink = false;
            Room room = new Room(x, y);
            Clock clock = new Clock();
            UI ui = new UI();
            Plane plane = new Plane();
            ui.DisplayPlane(plane);
            while (true)
            {
                clock.WaitFractionsOfASecond(20);
                if (xshrink)
                {
                    x--;
                }
                else
                {
                    x++;
                }
                if (yshrink)
                {
                    y--;
                }
                else
                {
                    y++;
                }
                plane.DestroyAll();
                Room modRoom = new Room(x, y);
                plane.AddRoom(modRoom, 1, 1);
                ui.DisplayPlane(plane);
                if(x == 1)
                {
                    xshrink = false;
                }
                else if(x == 131)
                {
                    xshrink = true;
                }
                if(y == 1)
                {
                    yshrink = false;
                }
                else if(y == 25)
                {
                    yshrink = true;
                }
            }
        }
    }
}

