﻿using Ovning3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Prsn
{
    public class Wolfman : Wolf, IPerson
    {
        public string Talk()
        {
            return "You tast like dog food!";
        }
    }
}
