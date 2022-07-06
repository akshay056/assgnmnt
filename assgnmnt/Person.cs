using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class Person
    {
            public string name
            {
                get; set;
            }
            public string address { get; set; }
            public DateTime Dob { get; set; }
            public string status { get; set; }
            private int age;

            public int getAge()
            {
                age = (int)DateTime.Today.Year - this.Dob.Year;
                return age;

                //age = (int)(DateTime.Now - this.dob).TotalDays / 365;
                //return age;
            }
            public bool CanMarry()
            {
                if (getAge() > 18)
                { return true; }
                else { return false; }
            }
            public string PrintDetails()
            {
                if (CanMarry() == true)
                { return $"{this.name} lives at {this.address}, born on {this.Dob},{this.status}, {getAge()} years old and can marry."; }
                else { return $"{this.name} lives at {this.address}, born on {this.Dob},{this.status}, {this.age} years old and can't marry now."; }
            }
        
    }
}
