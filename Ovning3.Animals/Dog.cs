using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Dog : Animal
    {
        private int _holeDiggingStat;

        public int HoleDiggingStat
        {
            get { return _holeDiggingStat; }
            set { _holeDiggingStat = value; }
        }
        public override string DoSound()
        {
            return "Bark";
        }
        public override string Stats()
        {
            return $"{base.Stats()}, how many holes have it dugg = {HoleDiggingStat}";

        }
    }
}
