using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Animals
{
    public abstract class Animal
    {
        private int _age;
        private int _weight;
        private string _name;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Animal()
        {
            _age = 0;
            _weight = 0;
            _name = "Animal";
        }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"age = {_age}, weight = {_weight}, name = {_name}";
        }
    }
}
