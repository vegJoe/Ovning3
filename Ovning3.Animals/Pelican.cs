using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Pelican : Bird
    {
        private float _beakVolume;

        public float BeakVolume
        {
            get { return _beakVolume; }
            set { _beakVolume = value; }
        }
        public override string DoSound()
        {
            return "Gulp";
        }
    }
}
