using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo.Human
{
    public class Student:Human
    {
        private int grade;
        public Student(string fName, string lName, int initGrade):base(fName, lName)
        {
            this.grade = 1;
        }
        public int getGrade()
        {
            return this.grade;
        }
        public void setGrade(int initGrade)
        {
            this.grade = initGrade;
        }
    }
}
