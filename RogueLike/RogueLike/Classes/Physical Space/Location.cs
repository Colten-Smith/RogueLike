
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Physical_Space.Items;
using RogueLike.Classes.Physical_Space.Floors;
using System.Net.Http.Headers;

namespace RogueLike.Classes.Physical_Space
{
    public class Location
    {
        //Properties
        //#############//

        /// <summary>
        /// The location's position on the X Axis.
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// THe location's position on the Y Axis.
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// The floor at this location.
        /// </summary>
        private Floor Floor { get; set; }

        /// <summary>
        /// The Item on the floor at this location.
        /// </summary>
        private Item Item { get; set; }


        //Constructors
        //##############//

        /// <summary>
        /// A location in space.
        /// </summary>
        /// <param name="x">The location's position on the X Axis.</param>
        /// <param name="y">The location's position on the Y Axis.</param>
        /// <param name="floor">The floor at this location.</param>
        /// <param name="item">The Item on the floor at this location.</param>
        public Location(int x, int y, Floor floor, Item item = null)
        {
            if (item == null)
            {
                item = new Air();
            }
            X = x;
            Y = y;
            Floor = floor;
            Item = item;
        }



        //Methods
        //#########//

        /// <summary>
        /// Replaces the item at this location with a new one.
        /// </summary>
        /// <param name="newItem">The item to add to this location.</param>
        /// <returns>The item previously at this location.</returns>
        public Item ChangeItem(Item newItem)
        {
            if (newItem == null)
            {
                return null;
            }
            Item output = Item;
            Item = newItem;
            return output;
        }

        /// <summary>
        /// Removes whatever item is at this location and leaves empty air.
        /// </summary>
        /// <returns>The item removed.</returns>
        public Item RemoveItem()
        {
            Item output = Item;
            ChangeItem(new Air());
            return output;
        }

        public Item GetItem()
        {
            return Item;
        }
        public Floor GetFloor()
        {
            return Floor;
        }
        public Item SwapItem(Item newItem)
        {
            Item oldItem = Item;
            Item = newItem;
            return oldItem;
        }
        public bool SwapItems(Location locationToSwapItems, bool overrideAirCheck = false)
        {
            if(Item.GetType() == typeof(Air) || locationToSwapItems.Item.GetType() == typeof(Air) || overrideAirCheck)
            {
                locationToSwapItems.SwapItem(SwapItem(locationToSwapItems.Item));
                return true;
            }
            return false;
        }
    }
}
