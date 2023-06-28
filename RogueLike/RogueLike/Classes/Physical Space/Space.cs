using RogueLike.Classes.Physical_Space.Floors;
using RogueLike.Classes.Physical_Space.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space
{
    public class Space
    {
        //Properties
        //############//

        /// <summary>
        /// Dictionary containing every location in the space, along with all of the location's properties.
        /// </summary>
        private Dictionary<string, Location> PossibleLocations { get; set; }

        /// <summary>
        /// The Width of the Space.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// The Length of the Space.
        /// </summary>
        public int Length { get; private set; }


        //Constructors
        //##############//

        /// <summary>
        /// A physical 2-dimensional space.
        /// </summary>
        /// <param name="width">The Width of the space.</param>
        /// <param name="length">The Length of the space.</param>
        public Space(int width, int length)
        {
            Width = width;
            Length = length;
            PossibleLocations = new Dictionary<string, Location>();
            for (int x = 1; x <= Width; x++)
            {
                for (int y = 1; y <= Width; y++)
                {
                    Location currentLocation = new Location(x, y, new Basic_Floor());
                    PossibleLocations[$"{currentLocation.X},{currentLocation.Y}"] = currentLocation;
                }
            }
        }

        //Methods
        //#########//

        public Item ChangeItem(string coordinate, Item item)
        {
            if (item == null || !PossibleLocations.ContainsKey(coordinate))
            {
                return null;
            }
            return PossibleLocations[coordinate].ChangeItem(item);
        }
        public Item RemoveItem(string coordinate)
        {
            if (!PossibleLocations.ContainsKey(coordinate))
            {
                return null;
            }
            return PossibleLocations[coordinate].RemoveItem();
        }


        public Item GetItem(string coordinate)
        {
            if (!PossibleLocations.ContainsKey(coordinate))
            {
                return null;
            }
            return PossibleLocations[coordinate].GetItem();
        }

        public bool MoveItem(string coordinate1, string coordinate2)
        {
            if (PossibleLocations[coordinate1].GetType() == typeof(Air) || PossibleLocations[coordinate1].GetType() == typeof(Air))
            {
                Item item1 = PossibleLocations[coordinate1].RemoveItem();
                Item item2 = PossibleLocations[coordinate2].RemoveItem();
                PossibleLocations[coordinate1].ChangeItem(item2);
                PossibleLocations[coordinate2].ChangeItem(item1);
                return true;
            }
            return false;
        }
    }
}
