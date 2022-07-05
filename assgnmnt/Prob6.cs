using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class Prob6
    {

        public List<int> ReadIntegers()
        {
            List<int> sequence = new List<int>();
            string num = Console.ReadLine();
            while (num != string.Empty)
            {
                int input=int.Parse(num);
                sequence.Add(input);
                num= Console.ReadLine();
            }
            return sequence;
        }
        public string SumAndAverage(List<int> sequence)
        {
            double sum= sequence.Sum();
            double average= sequence.Average();
            return $"{sum} {average}";
  
        }
    }
}

