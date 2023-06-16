using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public static class UI
    {
        public static void DisplayChart(Chart chart)
        {
            Display(chart.GetSprites());
        }
        public static void Display(List<string> listToDisplay)
        {
            foreach(string line in listToDisplay)
            {
                Console.WriteLine(line);
            }
        }
        public static void Display(string stringToDisplay)
        {
            Console.WriteLine(stringToDisplay);
        }
    }
}
