using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Reflection.Metadata.Ecma335;
using RogueLike.Classes.Managers;
using RogueLike.Classes.Physical_Space;
using RogueLike.Classes.Physical_Space.Items;
using RogueLike.Classes.Physical_Space.Items.Walls;

namespace RogueLike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO Find out how to implement the timer
            //Scratch Code//

            //System.Timers.Timer testTimer = new System.Timers.Timer(1000 / 10);
            //testTimer.AutoReset = true;
            //testTimer.Elapsed += Tick;
            //testTimer.Start();
            //while (testTimer.Enabled)
            //{
            //    if (Console.KeyAvailable)
            //    {
            //        testTimer.Stop();
            //        testTimer.Dispose();
            //    }
            //}
            


            //Space testSpace = new Space(30, 30);
            //Person playerCharacter = new Person();
            //int playerX = 1;
            //int playerY = 1;
            //testSpace.ChangeItem($"{playerX},{playerY}", playerCharacter);
            //testSpace.ChangeItem($"1,2", new VerticalWall());
            //Level level = new Level("TestLevel", testSpace);

            //if (playerCharacter.Move(level.GetLocation(playerX, playerY), level.GetLocation(1, 2)))
            //{
            //    playerY = 2;
            //}


        }

        //private static void Tick(object? sender, System.Timers.ElapsedEventArgs e)
        //{
        //    Console.WriteLine("A");
        //}
    }
}