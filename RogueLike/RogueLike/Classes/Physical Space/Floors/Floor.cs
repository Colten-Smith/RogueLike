using RogueLike.Classes.Physical_Space.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Floors
{
    public abstract class Floor
    {
        //Properties
        //############//

        public char Sprite { get; private set; }
        protected Type[] ImmoveableItems { get; private set; }

        //Constructor
        //#############//

        public Floor(char sprite, Type[] moveables)
        {
            Sprite = sprite;
            ImmoveableItems = moveables;
        }

        //Methods//
        //#########//

        public abstract bool CanBeMovedOnBy(Type typeOfItemToMove);
    }
}
