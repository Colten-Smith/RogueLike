using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class UI
    {
        public int[] PlaneSizeMax = { 133, 27 };
        public void DisplayPlane(Plane plane)
        {
            for (int y = 1; y <= PlaneSizeMax[1]; y++)
            {
                string line = "";
                for(int x = 1; x <= PlaneSizeMax[0]; x++)
                {
                    if (plane.AllPoints.ContainsKey($"{x}|{y}"))
                    {
                        line += plane.AllPoints[$"{x}|{y}"].Item.Sprite;
                    }
                    else
                    {
                    line += " ";
                    }
                }
                Console.WriteLine(line);
            }
        }
    }
}
