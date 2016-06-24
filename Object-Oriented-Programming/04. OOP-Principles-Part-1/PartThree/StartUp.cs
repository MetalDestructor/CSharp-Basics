using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThree
{
    using Animal;
    class StartUp
    {
        static void Main(string[] args)
        {
            var dogs = AnimalGenerator.GenerateDogs();
            var frogs = AnimalGenerator.GenerateFrogs();
            var kittens = AnimalGenerator.GenerateKittens();
            var tomcats = AnimalGenerator.GenerateTomCats();

            AnimalCalculations.AvgAge(dogs);
            AnimalCalculations.AvgAge(frogs);
            AnimalCalculations.AvgAge(kittens);
            AnimalCalculations.AvgAge(tomcats);
        }
    }
}
