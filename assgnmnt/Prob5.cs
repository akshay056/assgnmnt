using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgnmnt
{
    public class Prob5
       {
        public string SubsetSum(int[] Numbers)
        {
            if (Numbers[0] == 0 && Numbers[1] == 0 && Numbers[2] == 0 && Numbers[3] == 0 && Numbers[4] == 0)
            {
                
                Console.WriteLine(String.Join("+", Numbers) + " = 0");
                return "sum is zero.";
            }
            for (int firstNum = 0; firstNum <= 3; firstNum++)
            {
                for (int secondNum = firstNum + 1; secondNum <= 4; secondNum++)
                {
                    if (Numbers[firstNum] + Numbers[secondNum] == 0)
                    {
                        return $"({ Numbers[firstNum]},{Numbers[secondNum]})";
                    }
                }
            }

            for (int firstNum = 0; firstNum <= 2; firstNum++)
            {
                for (int secondNum = firstNum + 1; secondNum <= 3; secondNum++)
                {
                    for (int thirdNum = secondNum + 1; thirdNum <= 4; thirdNum++)
                    {
                        if (Numbers[firstNum] + Numbers[secondNum] + Numbers[thirdNum] == 0)
                        {
                           
                            return $"({Numbers[firstNum]},{Numbers[secondNum]},{Numbers[thirdNum]})";
                        }
                    }
                }
            }

            for (int firstNum = 0; firstNum <= 1; firstNum++)
            {
                for (int secondNum = firstNum + 1; secondNum <= 2; secondNum++)
                {
                    for (int thirdNum = secondNum + 1; thirdNum <= 3; thirdNum++)
                    {
                        for (int fourthNum = thirdNum + 1; fourthNum <= 4; fourthNum++)
                        {
                            if (Numbers[firstNum] + Numbers[secondNum] + Numbers[thirdNum] + Numbers[fourthNum] == 0)
                            {
                               
                                return $"({Numbers[firstNum]},{Numbers[secondNum]},{Numbers[thirdNum]},{Numbers[fourthNum]})";
                            }
                        }
                    }
                }
            }
        }
    }
}
