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
            Console.Clear();
            Console.WriteLine(plane.GetPlaneDisplay());
        }
    }
}
