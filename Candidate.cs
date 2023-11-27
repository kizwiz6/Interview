using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int YearsOfExperience { get; set; }
        public string Location { get; set; }

        public Candidate(string name, int age, int yearsOfExperience, string location)
        {
            Name = name;
            Age = age;
            YearsOfExperience = yearsOfExperience;
            Location = location;
        }
    }
}
