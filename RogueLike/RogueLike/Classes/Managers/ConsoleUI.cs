using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Managers
{
    public static class ConsoleUI
    {
        //Properties//
        //############//
        public static List<string> HUD { get; private set; }


        //Methods//
        //#########//
        public static bool ChangeHud(List<string> newHud)
        {
            if(newHud == null)
            {
                return false;
            }
            HUD = newHud;
            return true;
        }

        //Display Methods//
        //#################//

        public static bool DisplayText(string textToDisplay)
        {
            if(textToDisplay == null)
            {
                return false;
            }
            Console.WriteLine(textToDisplay);
            return true;
        }
        
        public static bool DisplayText(List<string> textToDisplay)
        {
            if(textToDisplay == null)
            {
                return false;
            }
            foreach(string line in textToDisplay)
            {
                if(line == null)
                {
                    return false;
                }
                Console.WriteLine(line);
            }
            return true;
        }
        public static bool DisplayHud()
        {
            if (HUD == null)
            {
                return false;
            }
            foreach (string line in HUD)
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
