using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Bird : Animal
    {
        private int _wings;

        public int Wings
        {
            get { return _wings; }
            set { _wings = value; }
        }
        public override string DoSound()
        {
            return "KaaKAAA";
        }

        public override string Stats()
        {
            return $"{base.Stats()}, wings = {Wings}";
        }
    }
}
