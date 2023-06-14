using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Plane
    {
        private Dictionary<string, Point> AllPoints { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        public Plane(int width = 133, int height = 27)
        {
            Width = width;
            Height = height;
            AllPoints = new Dictionary<string, Point>();
            for (int y = 1; y <= height; y++)
            {
                for (int x = 1; x <= width; x++)
                {
                    AllPoints[$"{x}|{y}"] = new Point($"{x}|{y}");
                }
            }
        }
        public string GetPlaneDisplay()
        {
            string output = "";
            for (int y = 1; y <= Height; y++)
            {
                string line = "";
                for (int x = 1; x <= Width; x++)
                {
                    if (AllPoints.ContainsKey($"{x}|{y}"))
                    {
                        line += AllPoints[$"{x}|{y}"].Item.Sprite;
                    }
                    else
                    {
                        line += " ";
                    }
                }
                output += line + "\n";
            }
            return output;


        }
        private bool CheckIfSpaceAvailable(Room roomToAdd, int leftWall, int topWall)
        {
            for(int y = topWall; y < roomToAdd.Height + topWall; y++)
            {
                for(int x = leftWall; x < roomToAdd.Width; x++)
                {
                    if (!AllPoints.ContainsKey($"{x}|{y}") || !AllPoints[$"{x}|{y}"].CanBeMovedTo())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool AddRoom(Room roomToAdd, int leftWall, int topWall)
        {
            if(CheckIfSpaceAvailable(roomToAdd, leftWall, topWall))
            {
                foreach(string key in roomToAdd.ItemDict.Keys)
                {
                    string[] originalCoordinates = key.Split('|');
                    int x = int.Parse(originalCoordinates[0]) + leftWall - 1;
                    int y = int.Parse(originalCoordinates[1]) + topWall - 1;
                    AllPoints[x + "|" + y] = roomToAdd.ItemDict[key];
                }
                return true;
            }
            return false;
        }
        public void DestroyAll()
        {
            AllPoints = new Dictionary<string, Point>();
            for (int y = 1; y <= Height; y++)
            {
                for (int x = 1; x <= Width; x++)
                {
                    AllPoints[$"{x}|{y}"] = new Point($"{x}|{y}");
                }
            }
        }
    }
}
