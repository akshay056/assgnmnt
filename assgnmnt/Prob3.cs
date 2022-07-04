using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class Prob3
    {
        public int AddDigits(int number)
        {
            int sum = 0;
            string num = number.ToString();
            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num.Substring(i, 1));
            }
            return sum;
        }
        public int ReverseDigit(int number)
        {
            int rem,reverse=0;
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            return reverse;
        }
        public int MoveDigit(int number)
        {
            int div = number / 10;
            int temp = 1;
            while (temp <= div) { temp *= 10; }
            return (number % 10) * temp + div;
        }
        public string SwapDigits(int number)
        { 
            int n1 = (number / 1000)%10;
            int n2 = (number / 100)% 10;
            int n3 = (number / 10) % 10;
            int n4 = number % 10;
            return $"{n1}{n3}{n2}{n4}";
        }
    }
}
