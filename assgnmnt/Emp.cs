using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Emp
    {
        public int empid;
        public string name;
        protected string department;
        private int salary;
        private int _salary;
        public DateTime DOJ;
        public int nod;
        public int noy;

        //properties
        //getter - to read data
        //setter - to write data

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
                if (Sal >= 60000)
                    return 3;
                else
                    return 2;
            }
            set { salary = value;
                _salary = salary * 80;
            }
        }

        public int NumberOfDays()
        { 
            nod = (int)(DateTime.Now - DOJ).TotalDays;
            noy = nod / 365;
            return noy;
        }
        override public string ToString()
        {
            return $"Id={this.empid}Name={this.name} Salary(in Rs)={this._salary} Duration = {NumberOfDays()} years ";
        }
    }
}
