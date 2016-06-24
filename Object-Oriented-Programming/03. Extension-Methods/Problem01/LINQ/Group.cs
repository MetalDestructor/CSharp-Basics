using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.LINQ
{
    public class Group
    {
        public Group(int groupNumber, string groupName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = groupName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
