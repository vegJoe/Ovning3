using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public class Wolf : Animal
    {
        private bool _friendly = false;

        public bool Friendly
        {
            get { return _friendly; }
            set { _friendly = value; }
        }
        public override string DoSound()
        {
            return "AAAAUUUUUUU";
        }
        public override string Stats()
        {
            return $"{base.Stats()}, friendly = {Friendly}";
        }
    }
}
