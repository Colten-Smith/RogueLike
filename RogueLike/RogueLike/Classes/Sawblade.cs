using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    //TODO Complete Sawblade Methods
    public class Sawblade : Spike
    {
        public byte[] Pattern { get; private set; }
        public Sawblade(int x, int y, byte[] pattern, char sprite = 'X'/*¤*/) : base(x, y, sprite)
        {
            Pattern = pattern;
        }
        public void Move() { }
    }
}
