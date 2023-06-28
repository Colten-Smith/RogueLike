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
        /// <summary>
        /// </summary>
        protected List<DataType> InteractableTypes { get; private set; }

        //Constructors//
        //##############//

        public Item(char sprite, List<DataType> interactables)
        {
            Sprite = sprite;
            InteractableTypes = interactables;
        }

        //Methods//
        //#########//

        public abstract bool InteractWith(Item interactingItem);
    }
}
