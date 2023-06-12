using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Item
    {
        public char Sprite { get; private set; }
        public bool IsSolid { get; private set; }
        public bool IsMovable { get; private set; }
        public bool IsGettable { get; private set; }
        public Item()
        {
            Sprite = ('·');
            IsSolid = false;
            IsGettable = false;
        }
        public Item(char sprite,bool isSolid, bool isMovable, bool isGettable)
        {
            Sprite = sprite;
            IsSolid = isSolid;
            IsMovable = isMovable;
            IsGettable = isGettable;
        }
    }
}
