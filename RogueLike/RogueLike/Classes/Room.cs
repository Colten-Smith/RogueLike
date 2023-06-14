using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Room
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Wall TopLeft { get; private set; } = new Wall('┌');
        public Wall TopRight { get; private set; } = new Wall('┐');
        public Wall BottomLeft { get; private set; } = new Wall('└');
        public Wall BottomRight { get; private set; } = new Wall('┘');
        public Wall Horizontal { get; private set; } = new Wall('─');
        public Wall Vertical { get; private set; } = new Wall('│');
        public Item Floor { get; private set; } = new Item('·', false, false, false);
        public Dictionary<string, Point> ItemDict { get; private set; } = new Dictionary<string, Point>();


        public Room(int width, int height)
        {
            int x = 1;
            int y = 1;
            Width = width;
            Height = height;
            ItemDict[$"{x}|{y}"] = new Point(TopLeft, $"{x}|{y}");
            for (x++; x <= Width + 1; x++)
            {
                ItemDict[$"{x}|{y}"] = new Point(Horizontal, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(TopRight, $"{x}|{y}");
            for (y++; y <= Height + 1; y++)
            {
                ItemDict[$"{x}|{y}"] = new Point(Vertical, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(BottomRight, $"{x}|{y}");
            for (x--; x > 1; x--)
            {
                ItemDict[$"{x}|{y}"] = new Point(Horizontal, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(BottomLeft, $"{x}|{y}");
            for (y--; y > 1; y--)
            {
                ItemDict[$"{x}|{y}"] = new Point(Vertical, $"{x}|{y}");
            }
            for (y++; y <= Height + 1; y++)
            {
                for (int tx = x + 1; tx <= Width + 1; tx++)
                {
                    ItemDict[$"{tx}|{y}"] = new Point(Floor, $"{tx}|{y}");
                }
            }
        }
        //todo add AddDoor Method
        public bool AddDoor(string coordinate)
        {
            Wall wall = new Wall('|');
            int[] coordinates = new int[2];
            coordinates[0] = int.Parse(coordinate.Split("|")[0]);
            coordinates[1] = int.Parse(coordinate.Split("|")[1]);
            if (ItemDict.ContainsKey(coordinate) && ((coordinates[0] == 1 || coordinate[0] == Width + 2)
                ^ (coordinates[1] == 1 || coordinates[1] == Height + 2)))
            {
                //todo Add AssignDoorframe method (int x, int y)
                ////Vertical
                //if (coordinates[0] == 1 || coordinate[0] == Width + 2)
                //{
                //    //Below
                //    if (ItemDict[$"{coordinates[0]}|{coordinates[1] + 1}"].GetType().Name == "Vertical")
                //    {
                //        //Left
                //        if (coordinates[0] == 1)
                //        {
                //            ItemDict[$"{coordinates[0]}|{coordinates[1] + 1}"] = new Point(TopRight, $"{coordinates[0]}|{coordinates[1] + 1}");
                //        }
                //        //Right
                //        else
                //        {
                //            ItemDict[$"{coordinates[0]}|{coordinates[1] + 1}"] = new Point(TopLeft, $"{coordinates[0]}|{coordinates[1] + 1}");
                //        }
                //    }
                //    //Above
                //    if (ItemDict[$"{coordinates[0]}|{coordinates[1] - 1}"].GetType().Name == "Vertical")
                //    {
                //        //Left
                //        if (coordinates[0] == 1)
                //        {
                //            ItemDict[$"{coordinates[0]}|{coordinates[1] + 1}"] = new Point(TopRight, $"{coordinates[0]}|{coordinates[1] + 1}");
                //        }
                //        //Right
                //        else
                //        {
                //            ItemDict[$"{coordinates[0]}|{coordinates[1] + 1}"] = new Point(TopLeft, $"{coordinates[0]}|{coordinates[1] + 1}");
                //        }
                //}
                //}
                return true;
            }
            return false;
        }

        //todo add AddItem Method
    }
}
