using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items
{
    public class Air : Item
    {
        /// <summary>
        /// An empty space.
        /// </summary>
        public Air() : base(' ')
        {

        }

        public override bool InteractWith(Item interactingItem)
        {
            return true;
        }
    }
}
