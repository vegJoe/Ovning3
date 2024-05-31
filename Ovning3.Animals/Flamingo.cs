using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Flamingo : Bird
    {
        private int _numOfLegsOnGround;

        public int NumOfLegsOnGround
        {
            get { return _numOfLegsOnGround; }
            set { _numOfLegsOnGround = value; }
        }
        public override string DoSound()
        {
            return "Miamiiiii";
        }
    }
}
