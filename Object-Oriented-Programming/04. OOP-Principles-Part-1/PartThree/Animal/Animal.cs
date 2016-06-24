using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThree.Animal
{
    public class Animal
    {
        public Animal(string name, int age, bool isFemale)
        {
            this.Name = name;
            this.Age = age;
            this.IsFemale = isFemale;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsFemale { get; set; }
    }
}
