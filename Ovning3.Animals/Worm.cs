using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Worm : Animal
    {
        private static string _taste = "Not good at all";

        public string Taste
        {
            get { return _taste; }
            private set { _taste = value; }
        }
        public override string DoSound()
        {
            return "____:)";
        }
        public override string Stats()
        {
            return $"{base.Stats()}, taste = {Taste}";
        }
    }
}
