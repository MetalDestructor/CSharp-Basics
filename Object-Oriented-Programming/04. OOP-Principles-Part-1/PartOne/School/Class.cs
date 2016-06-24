using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne.School
{
    using Optional;
    using Humans;
    public class Class:Description
    {
        public string Id { get; set; }
        public Teacher Teachers { get; set; }
    }
}
