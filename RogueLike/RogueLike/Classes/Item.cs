using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public abstract class Item
    {
        public int X_Position { get; private set; }
        public int Y_Position { get; private set; }
        public char Sprite { get; private set; }
        public Item(int x, int y, char sprite)
        {
            X_Position = x;
            Y_Position = y;
            Sprite = sprite;
        }


        //    public char Sprite { get; private set; }
        //    public bool IsSolid { get; private set; }
        //    public bool IsMovable { get; private set; }
        //    public bool IsGettable { get; private set; }
        //    public bool IsDamage { get; private set; }
        //    public bool IsReplaceable { get; private set; }
        //    public Item()
        //    {
        //        Sprite = (' ');
        //        IsReplaceable = true;
        //        IsSolid = false;
        //        IsMovable = false;
        //        IsGettable = false;
        //        IsDamage = false;
        //    }
        //    public Item(char sprite,bool isSolid, bool isMovable, bool isGettable, bool isDamage, bool isReplaceable)
        //    {
        //        Sprite = sprite;
        //        IsSolid = isSolid;
        //        IsMovable = isMovable;
        //        IsGettable = isGettable;
        //        IsDamage = isDamage;
        //        IsReplaceable = isReplaceable;
    }
}

