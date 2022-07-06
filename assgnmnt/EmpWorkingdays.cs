using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class EmpWorkingdays
    {
        public int empid;
        public string name;
        protected string department;
        private int salary;
        private int _salary;
        public DateTime DOJ;
        public int nod;
        public string Dept
        {
            get
            {
                return department;
            }
            set { department = value; }
        }

        public int Sal
        {

            get
            {
                return salary;
            }
            set
            {
                salary = value;
                _salary = salary * 80;
            }
        }

        public int NumberOfDays()
        {
            nod = (int)(DateTime.Now - DOJ).TotalDays;
            return nod;
        }
        override public string ToString()
        {
            return $"Id={this.empid}Name={this.name} Salary(in Rs)={this._salary} Duration = {NumberOfDays()} years ";
        }
    }
}

