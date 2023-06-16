using RogueLike.Classes;
using System.Security.Cryptography.X509Certificates;

namespace RogueLike
{
    //TODO redo program logic by starting with tests
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO Refactor entire program

            //Console.WriteLine("   │·│      ");
            //Console.WriteLine("┌──┘·└─────┐");
            //Console.WriteLine("│··········└────┐");
            //Console.WriteLine("│···@······%····│");
            //Console.WriteLine("│······?···┌┐···│");
            //Console.WriteLine("└──────────┘└───┘");
            LevelBuilder lb = new LevelBuilder();
            lb.TopLeftCornerWall();
            lb.HorizontalWall(8);
            lb.TopRightCornerWall();
            lb.VerticalWall(8);
            lb.BottomRightCornerWall();
            lb.HorizontalWall(8, true);
            lb.BottomLeftCornerWall();
            lb.VerticalWall(8, true);
            lb.AddPlayerCharacter(5, 6);
            byte[] SBP = { 1, 1, 1, 1, 3, 3, 3, 3 };
            lb.AddSawBlade(6, 3, SBP);
            lb.AddLockedDoor(8, 6);
            Chart chart = new Chart(lb.GetLevel(), 10, 10);
            UI.DisplayChart(chart);
        }
    }
}