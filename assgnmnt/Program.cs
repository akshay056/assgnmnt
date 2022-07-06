using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. and 2.

            //DateTime CurrentDay = DateTime.Now;
            //Console.Write("Enter your date of birth (dd/mm/yyyy) : ");
            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //DateTime dob = new DateTime(year, month, day);
            //int age = CurrentDay.Year - dob.Year;
            //int AgeAfterTen = age + 10;
            //Console.WriteLine($"Current day is:{CurrentDay}");
            //Console.WriteLine($"Current age is : {age}");
            //Console.WriteLine($"Age after 10 years is : {AgeAfterTen}");



            ////3.
            //Console.WriteLine("Enter a four digit number : ");
            //int number = int.Parse(Console.ReadLine());
            //Prob3 s = new Prob3();
            //Console.WriteLine("The sum of the digits is :{0}", s.AddDigits(number));
            //Console.WriteLine("The reverse of the number is :{0}", s.ReverseDigit(number));
            //Console.WriteLine("The sum of the gigits is :{0}", s.MoveDigit(number));
            //Console.WriteLine("The number after swapping middle digits is :{0}", s.SwapDigits(number));



            ////4.
            //Console.Write("Enter company name: ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter address: ");
            //string Address = Console.ReadLine();
            //Console.Write("Enter phone number: ");
            //string Phone = Console.ReadLine();
            //Console.Write("Enter fax: ");
            //string Fax = Console.ReadLine();
            //Console.Write("Enter company website: ");
            //string WebSite = Console.ReadLine();
            //Console.Write("Enter company manager: ");
            //string Manager = Console.ReadLine();
            //Console.Write("Enter manager first name: ");
            //string FName = Console.ReadLine();
            //Console.Write("Enter manager last name: ");
            //string LName = Console.ReadLine();
            //Console.Write("Enter manager phone: ");
            //string mPhone = Console.ReadLine();

            //Console.WriteLine($"Firm: Name - {Name}, Address - {Address}, Number - {Phone}, Fax - {Fax}, Website - {WebSite}, Manager - {Manager}");
            //Console.WriteLine($"Manager: Name - {FName} {LName}, Phone - {mPhone}");



            //5.
            //int[] Numbers = new int[5];
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("Input number {0}", i + 1);
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //if (Numbers[0] == 0 && Numbers[1] == 0 && Numbers[2] == 0 && Numbers[3] == 0 && Numbers[4] == 0)
            //{
            //    Console.WriteLine(String.Join("+", Numbers) + " = 0");
            //    Console.WriteLine("sum is zero.");
            //}
            //for (int firstNum = 0; firstNum <= 3; firstNum++)
            //{
            //    for (int secondNum = firstNum + 1; secondNum <= 4; secondNum++)
            //    {
            //        if (Numbers[firstNum] + Numbers[secondNum] == 0)
            //        {

            //            Console.WriteLine($"({Numbers[firstNum]},{Numbers[secondNum]})");
            //        }
            //    }
            //}
            //for (int firstNum = 0; firstNum <= 2; firstNum++)
            //{
            //    for (int secondNum = firstNum + 1; secondNum <= 3; secondNum++)
            //    {
            //        for (int thirdNum = secondNum + 1; thirdNum <= 4; thirdNum++)
            //        {
            //            if (Numbers[firstNum] + Numbers[secondNum] + Numbers[thirdNum] == 0)
            //            {
            //                Console.WriteLine($"({Numbers[firstNum]},{Numbers[secondNum]},{Numbers[thirdNum]})");
            //            }
            //        }
            //    }
            //}
            //for (int firstNum = 0; firstNum <= 1; firstNum++)
            //{
            //    for (int secondNum = firstNum + 1; secondNum <= 2; secondNum++)
            //    {
            //        for (int thirdNum = secondNum + 1; thirdNum <= 3; thirdNum++)
            //        {
            //            for (int fourthNum = thirdNum + 1; fourthNum <= 4; fourthNum++)
            //            {
            //                if (Numbers[firstNum] + Numbers[secondNum] + Numbers[thirdNum] + Numbers[fourthNum] == 0)
            //                {

            //                    Console.WriteLine($"({Numbers[firstNum]},{Numbers[secondNum]},{Numbers[thirdNum]},{Numbers[fourthNum]})");
            //                }
            //            }
            //        }
            //    }
            //}


            //Tried solving this way but was not getting output.
            //List<int> intList = new List<int>() { 1, 2, -3, 4, 5 };
            //List<int> Slist = new List<int>();
            //int n = intList.Count; Console.WriteLine(n);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j=1;j<n;j++)
            //    {
            //        List<int> slist = intList.GetRange(i,j);
            //        Console.WriteLine(String.Join(",", slist));
            //        int sum = slist.Aggregate((x, y) => x + y);
            //        Console.WriteLine(sum);
            //    }
            //}


            //6.
            //Prob6 p=new Prob6();
            //Console.WriteLine("Enter the numbers:");
            //List<int> sequence = p.ReadIntegers();
            //Console.WriteLine("The sum and average of the numbers is: " + p.SumAndAverage(sequence));


            //7.
            //var emps = new EmpWorkingdays[] {
            //new EmpWorkingdays { empid=22554,name="Darshith",Sal=600000, Dept="Azure MCS",DOJ = new DateTime(2020, 6, 22)},
            //new EmpWorkingdays { empid=22559,name="Sreedhar",Sal=600000, Dept="D365",DOJ = new DateTime(2021, 6, 22)},
            //new EmpWorkingdays { empid=22563,name="Akshay",Sal=600000, Dept="D365",DOJ = new DateTime(2022, 6, 22)}
            //};
            //foreach (var e in emps)
            //    Console.WriteLine(e.ToString());


            //9.
            //Worker h = new Worker();
            //h.FirstName = "akshay";
            //h.LastName = "upadhya";
            //h.wage = 1311434;
            //h.hoursWorked = 2;
            //Console.WriteLine(h.print());


            //10.
            //Person p = new Person();
            //Console.WriteLine("enter name: ");
            //p.name = Console.ReadLine();
            //Console.WriteLine("enter date of birth");
            ////p.Dob = new DateTime(2000, 5, 6);
            //p.Dob = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("enter address: ");
            //p.address = Console.ReadLine();
            //Console.WriteLine("enter marriage status: ");
            //p.status = Console.ReadLine();
            //Console.WriteLine($"Can he marry ? {p.CanMarry()}");
            //Console.WriteLine(p.PrintDetails());

        }
    }
}