using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo.Human
{
    public class Worker:Human
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string fName, string lName, double weekSalary, int workHoursPerDay):base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double moneyPerDay = this.WeekSalary / 5;
            double moneyPerHour = moneyPerDay / this.WorkHoursPerDay;
            return moneyPerHour;
        }
    }
}
