using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThree.Animal
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, bool isFemale) : base(name, age, isFemale)
        {

        }
        public void Greetings()
        {
            Console.WriteLine("Kwaka");
        }
    }
}
