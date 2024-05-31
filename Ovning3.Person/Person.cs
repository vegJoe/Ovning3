using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Prsn
{
    public class Person
    {
        private int _age;
        private string _fName = null!;
        private string _lName = null!;
        private double _height;
        private double _weight;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    throw new ArgumentException("Value lower than 0");
            }
        }

        public string FName
        {
            get
            {
                return _fName;
            }
            set
            {
                if (value != null && value.Length >= 2 && value.Length <= 10)
                    _fName = value;
                else
                    throw new ArgumentException("First name need to be more than 2 characters and less than 10");
            }
        }

        public string LName
        {
            get
            {
                return _lName;
            }
            set
            {
                if (value != null && value.Length >= 3 && value.Length <= 15)
                    _lName = value;
                else
                    throw new ArgumentException("Last name need to be more than 3 characters and less than 15");
            }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
