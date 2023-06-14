
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Point
    {
        public Item Item { get; private set; }
        public string Coordinate { get; private set; }
        public Point(Item item, string coordinate)
        {
            Item = item;
            Coordinate = coordinate;
        }
        public Point(string coordinate)
        {
            Item = new Item();
            Coordinate = coordinate;
        }
        public bool SwapItem(Item newItem)
        {
            if (Item.IsSolid)
            {
                return false;
            }
            Item = newItem;
            return true;
        }
        public bool CanBeMovedTo()
        {
            if (Item.IsSolid || Item.IsMovable || Item.IsGettable)
            {
                return false;
            }
            return true;
        }
        public bool MoveItem(Point newSpot)
        {
            if (newSpot.CanBeMovedTo() && Item.IsMovable)
            {
                newSpot.SwapItem(Item);
                Item = new Item();
                return true;

            }
            return false;
        }
        public bool MoveItem(Item newItem, Point newSpot)
        {
            if (newSpot.CanBeMovedTo())
            {
                newSpot.SwapItem(Item);
                Item = newItem;
                return true;
            }
            return false;
        }
    }
}
