using RogueLike.Classes.Physical_Space.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Floors
{
    public class Basic_Floor : Floor
    {
        /// <summary>
        /// A floor that any item can rest on.
        /// </summary>
        public Basic_Floor() : base(' ', new List<DataType>())
        {
            
        }
        
        //Methods//
        //#########//
        public override bool CanBeMovedOnBy(Item itemToMove)
        {
            return true;
        }
    }
}
