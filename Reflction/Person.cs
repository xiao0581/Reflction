using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflction
{

public abstract class Person
    {
        public string Name { get; set; }
        public int BirthOfYear { get; set; }

        public Person(string name, int birthOfYear)
        {
            Name = name;
            BirthOfYear = birthOfYear;
        }

        public int Age => DateTime.Now.Year - BirthOfYear;
    }
}
