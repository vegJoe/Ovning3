using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Swan : Bird
    {
        private float _divingAbilityInM;

        public float DivingAbilityInM
        {
            get { return _divingAbilityInM; }
            set { _divingAbilityInM = value; }
        }
        public override string DoSound()
        {
            return "Growl";
        }
    }
}
