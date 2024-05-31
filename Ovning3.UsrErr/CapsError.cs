using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.UsrErr
{
    internal class CapsError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use only capital letters in text. This fired an error!";
        }
    }
}
