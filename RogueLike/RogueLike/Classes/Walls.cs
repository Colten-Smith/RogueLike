using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Wall : Item
    {
        public Item TopLeft { get; private set; } = new Item('┌', true, false, false);
        public Item TopRight { get; private set; } = new Item('┐', true, false, false);
        public Item BottomLeft { get; private set; } = new Item('└', true, false, false);
        public Item BottomRight { get; private set; } = new Item('┘', true, false, false);
        public Item Horizontal { get; private set; } = new Item('─', true, false, false);
        public Item Vertical { get; private set; } = new Item('│', true, false, false);
        public Wall(char sprite) : base(sprite, true, false, false) { }
    }
}
