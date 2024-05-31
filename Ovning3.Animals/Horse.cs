using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Horse : Animal
    {
        private int _numOfApplesEaten;

        public int NumOfApplesEaten
        {
            get { return _numOfApplesEaten; }
            set {  _numOfApplesEaten = value; }
        }
        public override string DoSound()
        {
            return "IIIIAAAHH";
        }
        public override string Stats()
        {
            return $"{base.Stats()}, number of apples eaten = {NumOfApplesEaten}";
        }
    }
}
