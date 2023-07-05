using RogueLike.Classes.Physical_Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Managers
{
    public static class ConsoleUI
    {
        //Properties//
        //############//


        //Methods//
        //#########//

        //Display Methods//
        //#################//

        public static bool DisplayText(string textToDisplay)
        {
            if (textToDisplay == null)
            {
                return false;
            }
            Console.WriteLine(textToDisplay);
            return true;
        }

        public static bool DisplayText(List<string> textToDisplay)
        {
            if (textToDisplay == null)
            {
                return false;
            }
            foreach (string line in textToDisplay)
            {
                if (line == null)
                {
                    return false;
                }
                Console.WriteLine(line);
            }
            return true;
        }
        
    }
}
