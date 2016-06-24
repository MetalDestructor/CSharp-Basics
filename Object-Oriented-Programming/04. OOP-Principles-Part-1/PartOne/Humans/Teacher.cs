using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne.Humans
{
    using School;
    public class Teacher:Person
    {
        public Discipline[] Disciplines { get; set; }
    }
}
