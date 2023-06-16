using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Portal : Item
    {
        //TODO Create Portal Class
        public int Target_X { get; private set; }
        public int Target_Y { get; private set; }
        public Portal(int x, int y, int targetX, int targetY, char sprite = '╬') : base(x, y, sprite)
        {
            Target_X = targetX;
            Target_Y = targetY;
        }
    }
}
