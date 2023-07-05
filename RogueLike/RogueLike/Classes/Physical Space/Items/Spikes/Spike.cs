using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items.Spikes
{
    public class Spike : Item
    {

        protected override Type[] InteractableTypes { get; set; }

        protected override Type[] MoveableItems { get; set; }

        public Spike() : base('Ʌ')
        {

        }

        public override bool CanBeMovedTo(Type interactingItemType)
        {
            return false;
        }

        public override bool CanInteractWith(Type interactingItemType)
        {
            if (InteractableTypes.Contains(interactingItemType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
