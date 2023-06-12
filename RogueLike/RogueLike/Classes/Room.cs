using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Room
    {
        public int LeftCoord { get; private set; }
        public int TopCoord { get; private set; }
        public int RightCoord { get; private set; }
        public int BottomCoord { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Item TopLeftCorner { get; private set; } = new Item('┌', true, false, false);
        public Item TopRightCorner { get; private set; } = new Item('┐', true, false, false);
        public Item BottomLeftCorner { get; private set; } = new Item('└', true, false, false);
        public Item BottomRightCorner { get; private set; } = new Item('┘', true, false, false);
        public Item HorizontalWall { get; private set; } = new Item('─', true, false, false);
        public Item VerticalWall { get; private set; } = new Item('│', true, false, false);
        public Dictionary<string, Point> ItemDict { get; private set; } = new Dictionary<string, Point>();


        public Room(int leftCoord, int topCoord, int width, int height)
        {
            int x = leftCoord;
            int y = topCoord;
            LeftCoord = leftCoord;
            TopCoord = topCoord;
            Width = width;
            Height = height;
            RightCoord = LeftCoord + Width;
            BottomCoord = TopCoord + Height;
            ItemDict[$"{x}|{y}"] = new Point(TopLeftCorner, $"{x}|{y}");
            for (x++; x < RightCoord; x++)
            {
                ItemDict[$"{x}|{y}"] = new Point(HorizontalWall, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(TopRightCorner, $"{x}|{y}");
            for (y++; y < BottomCoord; y++)
            {
                ItemDict[$"{x}|{y}"] = new Point(VerticalWall, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(BottomRightCorner, $"{x}|{y}");
            for (x--; x > LeftCoord; x--)
            {
                ItemDict[$"{x}|{y}"] = new Point(HorizontalWall, $"{x}|{y}");
            }
            ItemDict[$"{x}|{y}"] = new Point(BottomLeftCorner, $"{x}|{y}");
            for (y--; y > TopCoord; y--)
            {
                ItemDict[$"{x}|{y}"] = new Point(VerticalWall, $"{x}|{y}");
            }
            for (y++; y < BottomCoord; y++)
            {
                for (int tx = x + 1; tx < RightCoord; tx++)
                {
                    ItemDict[$"{tx}|{y}"] = new Point($"{tx}|{y}");
                }
            }
        }
    }
}
