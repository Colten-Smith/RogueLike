using RogueLike.Classes;
using System.Security.Cryptography.X509Certificates;

namespace RogueLike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //todo make it so the screen updates every 30th of a second
            //todo create Room class to build rooms using previous code
            //Todo Workshop Player Mechanics/Player Tracker Class
            //Console.WriteLine("   │·│      ");
            //Console.WriteLine("┌──┌·┐─────┐");
            //Console.WriteLine("│··········┐");
            //Console.WriteLine("│···@······%");
            //Console.WriteLine("│······?···┘");
            //Console.WriteLine("└──────────┘");
            //
            //Item TopLeftCorner = new Item('┌', true, false, false);
            //Item TopRightCorner = new Item('┐', true, false, false);
            //Item BottomLeftCorner = new Item('└', true, false, false);
            //Item BottomRightCorner = new Item('┘', true, false, false);
            //Item HorizontalWall = new Item('─', true, false, false);
            //Item VerticalWall = new Item('│', true, false, false);
            //
            //int x = 1;
            //int y = 1;
            //
            //int a = 1;
            //int b = 1;

            Room room = new Room(1, 1, 30, 15);
            Plane plane = new Plane(room.ItemDict);
            plane.AddItem(new Player(), "30|15");
            UI ui = new UI();
            ui.DisplayPlane(plane);



        }
    }
}