using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThree
{
    using Animal;
    public class AnimalGenerator
    {
        public static List<Dog> GenerateDogs()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Kucho", 2, false),
                new Dog("Shakira", 12, true),
                new Dog("Pes", 8, false),
                new Dog("Djeka-Blek", 9, true),
            };

            return dogs;
        }

        public static List<Frog> GenerateFrogs()
        {
            List<Frog> frogs = new List<Frog>
            {
                new Frog("Jabcho", 1,false),
                new Frog("Goshka",18, true),
                new Frog("Kucamun",3, false),
                new Frog("Jabata-Tsar-Shefa", 50, false),
            };

            return frogs;
        }

        public static List<Kitten> GenerateKittens()
        {
            List<Kitten> kittens = new List<Kitten>
            {
                new Kitten("Kote",2 ),
                new Kitten("Machka",6 ),
                new Kitten("Kotarana",1 ),
                new Kitten("Piska",22 ),
            };

            return kittens;
        }

        public static List<Tomcat> GenerateTomCats()
        {
            List<Tomcat> tomcats = new List<Tomcat>
            {
                new Tomcat("Kotak",20 ),
                new Tomcat("Kotarak",4 ),
                new Tomcat("Loshiq-Tomcat", 14),
                new Tomcat("Kotka-s-Shapka", 18),
            };

            return tomcats;
        }
    }

}
