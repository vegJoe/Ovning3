using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Hedgehog : Animal
    {
        private int _damagePotential;

        public int DamagePotential
        {
            get { return _damagePotential; }
            set { _damagePotential = value; }
        }

        public override string DoSound()
        {
            return "squeek";
        }

        public override string Stats()
        {
            return $"{base.Stats()}, how much damage will it make = {DamagePotential}";
        }
    }
}
