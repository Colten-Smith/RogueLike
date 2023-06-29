using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items
{
    public abstract class Item
    {
        //Properties//
        //############//

        public char Sprite { get; private set; }
        protected abstract Type[] InteractableTypes { get; set; }
        protected abstract Type[] MoveableItems { get; set; }

        //Constructors//
        //##############//

        public Item(char sprite)
        {
            Sprite = sprite;
        }

        //Methods//
        //#########//

        public abstract bool CanInteractWith(Type interactingItemType);
        public abstract bool CanBeMovedTo(Type interactingItemType);
    }
}
