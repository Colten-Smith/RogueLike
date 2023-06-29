using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items
{
    public abstract class Base_Wall : Item
    {
        protected override Type[] InteractableTypes { get; set; }
        protected override Type[] MoveableItems { get; set; }
        protected Base_Wall(char sprite) : base(sprite)
        {

        }
        public override bool CanBeMovedTo(Type interactingItemType)
        {
            return false;
        }
        public override bool CanInteractWith(Type interactingItemType)
        {
            return false;
        }
    }
}
