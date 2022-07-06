using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Human
    {
        public int mark { get; set; }

    }
    class Worker : Human
    {
        public int wage { get; set; }
        public int hoursWorked { get; set; }

        public int HourlyWage() { return wage / hoursWorked; }

        public string print()
        {
            return $"Hourly wage of {this.FirstName} {this.LastName} is {HourlyWage()}";
        }
    }
}
