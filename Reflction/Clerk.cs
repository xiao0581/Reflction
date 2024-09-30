using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflction
{
    public  class Clerk: Person
    {
        public List<string> Skills { get; set; }

        public Clerk(string name, int birthOfYear, List<string> skills)
            : base(name, birthOfYear)
        {
            Skills = skills;
        }

       public override string ToString()
        {
            return $"Name: {Name}, BirthOfYear: {BirthOfYear}, Skills: {string.Join(", ", Skills)}";
        }
    }
}
