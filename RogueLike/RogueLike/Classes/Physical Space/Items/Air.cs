﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items
{
    public class Air : Item
    {
        protected override Type[] InteractableTypes { get; set; }
        protected override Type[] MoveableItems { get; set; }

        /// <summary>
        /// An empty space.
        /// </summary>
        public Air() : base(' ')
        {

        }

        public override bool CanInteractWith(Type interactingItemType)
        {
            return true;
        }
        public override bool CanBeMovedTo(Type interactingItemType)
        {
            return true;
        }
    }
}