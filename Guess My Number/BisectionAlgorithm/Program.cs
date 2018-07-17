using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class Program
    {
        static void Main()
        { START:
            try
            {
                int[] list =new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Please enter a number that is between 1 and 10 .");
                int number = int.Parse(Console.ReadLine());
                bisection(list, number);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter numbers 1-10 only.");
                goto START;
            }
        }

        private static void bisection(int[] selectionlist, int number)
        {
            int upperbound = selectionlist.GetUpperBound(0);
            int middlebound = upperbound / 2;
            int lowerbound = selectionlist.GetLowerBound(0);            
            int middleNumber = selectionlist[middlebound];

            if (number < middleNumber)
            {
                Console.WriteLine($"The number is lower than {middleNumber}");
                int[] lowerValues = new int[middlebound];

                for (int i = 0; i < lowerValues.Length; i++)
                {
                    lowerValues[i] = selectionlist[i];
                }
                bisection(lowerValues, number);
            }

            else if (number == middleNumber)
            {
                Console.WriteLine($"The number is {middleNumber}");
            }

            else if (number > middleNumber)
            {
                Console.WriteLine($"The number is higher than {middleNumber}");

                int[] higherValues = new int[upperbound - middlebound];                
                for (int i = 0; i < higherValues.Length; i++)
                {
                    higherValues[i] = selectionlist[++middlebound];                    
                }                
               bisection(higherValues, number);
            }

        }
    }
}

