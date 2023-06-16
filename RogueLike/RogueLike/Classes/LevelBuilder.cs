using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class LevelBuilder
    {
        private char TopLeftCorner = '┌';
        private char TopRightCorner = '┐';
        private char BottomLeftCorner = '└';
        private char BottomRightCorner = '┘';
        private int X = 1;
        private int Y = 1;
        public int Max_X { get; private set; } = 132;
        public int Max_Y { get; private set; } = 25;

        private Dictionary<string, Item> Level = new Dictionary<string, Item>();
        public LevelBuilder()
        {

        }
        public string GetCurrentCoordinates()
        {
            return $"{X}|{Y}";
        }
        public void HorizontalWall(int distance, bool goLeft = false)
        {
            if (!goLeft)
            {
                int tempX;
                    for (tempX = X + 1; tempX <= X + distance; tempX++)
                    {
                        Level[$"{tempX}|{Y}"] = new Wall(X, Y);
                    }
                    X = tempX;
                
            }
            else
            {
                int tempX;
                for (tempX = X - 1; tempX >= X - distance && tempX >= 0; tempX--)
                {
                    Level[$"{tempX}|{Y}"] = new Wall(X, Y);
                }
                X = tempX;
            }
        }
        public void VerticalWall(int distance, bool goUp = false)
        {
            if (!goUp)
            {
                int tempY;
                for (tempY = Y + 1; tempY <= Y + distance; tempY++)
                {
                    Level[$"{X}|{tempY}"] = new Wall(X, Y, '│');
                }
                Y = tempY;
            }
            else
            {
                int tempY;
                for (tempY = Y - 1; tempY >= Y - distance && tempY >= 0; tempY--)
                {
                    Level[$"{X}|{tempY}"] = new Wall(X, Y, '│');
                }
                Y = tempY;
            }
        }
        public void TopLeftCornerWall()
        {
            Level[$"{X}|{Y}"] = new Wall(X, Y, TopLeftCorner);
        }
        public void TopRightCornerWall()
        {
            Level[$"{X}|{Y}"] = new Wall(X, Y, TopRightCorner);
        }
        public void BottomLeftCornerWall()
        {
            Level[$"{X}|{Y}"] = new Wall(X, Y, BottomLeftCorner);
        }
        public void BottomRightCornerWall()
        {
            Level[$"{X}|{Y}"] = new Wall(X, Y, BottomRightCorner);
        }
        public void AddPlayerCharacter(int x, int y)
        {
            X = x;
            Y = y;
            Level[$"{X}|{Y}"] = new Character(X, Y);
        }
        public void AddLockedDoor(int x, int y)
        {
            X = x;
            Y = y;
            Level[$"{X}|{Y}"] = new LockedDoor(x, y);
        }
        public void AddSawBlade(int x, int y, byte[] pattern)
        {
            X = x;
            Y = y;
            Level[$"{X}|{Y}"] = new Sawblade(x, y, pattern);
        }
        public Dictionary<string, Item> GetLevel()
        {
            Dictionary<string, Item> output = new Dictionary<string, Item>(Level);
            return output;
        }
        //TODO Create Generate Floors Method
    }
}
