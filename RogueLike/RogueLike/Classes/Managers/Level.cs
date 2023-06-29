using RogueLike.Classes.Physical_Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Managers
{
    public class Level
    {
        //Properties
        //############//

        public string Name { get; private set; }
        public Space Space { get; private set; }

        //Constructor
        //#############//

        public Level(string name, Space space)
        {
            Name = name;
            Space = space;
        }

        //Methods
        //#########//

        public bool Run()
        {
            //TODO Build Level Run Method
            return true;
        }
        public Location GetLocation(string coordinate)
        {
            return Space.GetLocation(coordinate);
        }
        public Location GetLocation(int x, int y)
        {
            return Space.GetLocation(x, y);
        }
    }
}
