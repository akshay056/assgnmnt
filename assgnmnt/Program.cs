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
            //Console.Write("Enter your date of birth ");
            //int month = int.Parse(Console.ReadLine());
            //int day = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //DateTime dob = new DateTime(year, month, day);
            //int age=CurrentDay.Year - dob.Year;
            //int AgeAfterTen = age + 10;
            //Console.WriteLine($"Current day is:{CurrentDay}");
            //Console.WriteLine($"Current age is : {age}");
            //Console.WriteLine($"Age after 10 years is : {AgeAfterTen}");

            ////3.
            //Console.WriteLine("Enter the number : ");
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

            
            int[] Numbers = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Input number {0}", i + 1);
            }
            Prob5 p=new Prob5();
            Console.WriteLine(p.SubsetSum(Numbers));
           

            //List<int> values = new List<int>() { 1, 2, 3, 4, 5 };
            //int start = 1;
            //int end = 3;

            //List<int> subList = values.GetRange(start, end);

            //Console.WriteLine(String.Join(", ", subList));        // 2, 3, 4

            //List<int> intList = new List<int>() { 1,2,3,4,5 };
            //List<int> Slist = new List<int>();
            //int n = intList.Count; Console.WriteLine(n);
            //for (int i = 0;i < 2;i++)
            //{
            //    for(int j=2;j>=0;j--)
            //    { 
            //        List<int> slist = intList.GetRange(intList[i], intList[j]);
            //        Console.WriteLine(String.Join(",",slist));
            //        int sum = slist.Aggregate((x, y) => x + y);
            //        Console.WriteLine(sum);
            //    }
            //}

        }
    }
}