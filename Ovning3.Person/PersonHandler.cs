using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Prsn
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };

            return person;
        }
    }
}
