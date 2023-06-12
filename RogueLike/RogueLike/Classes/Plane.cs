using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Plane
    {
        public Dictionary <string, Point> AllPoints { get; private set; }

        public Plane(int width, int height)
        {
            AllPoints = new Dictionary<string, Point>();
            for(int y = 1; y <= height; y++)
            {
                for (int x = 1; x <= width; x++)
                {
                    AllPoints[$"{x}|{y}"] = new Point($"{x}|{y}");
                }
            }
        }
        public Plane(Dictionary<string, Point> allPoints)
        {
            AllPoints = allPoints;
        }
        public void AddItem(Item itemToAdd, string coordinates)
        {
            if (AllPoints[coordinates].CanBeMovedTo())
            {
                AllPoints[coordinates].SwapItem(itemToAdd);
            }
        }
    }
}
