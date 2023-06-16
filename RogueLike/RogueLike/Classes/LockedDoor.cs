using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class LockedDoor : Wall
    {
        public LockedDoor(int x, int y, char sprite = '#') : base(x, y, sprite)
        {
            
        }
    }
}
