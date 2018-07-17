using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayMean
    {
        static double sum = 0;
        static double mean = 0;
        static int count = 0;
        static void Main(string[] args)
        {
            ArrayA();
            ArrayB();
            ArrayC();
        }

        private static void ArrayA()
        {
            int[] A = new int[6] { 0, 2, 4, 6, 8, 10 };

            foreach (int i in A)
            {
                count++;
                sum += i;
                Console.WriteLine($"The count is {count} and the sum is {sum}.");
                mean = sum / count;
                if (count == A.Length)
                {
                    mean = sum / count;
                    Console.WriteLine($"The mean of array A is {mean}");
                    mean = sum = count = 0;
                }
            }
            Console.WriteLine("");
        }

        private static void ArrayB()
        {
            int[] B = new int[5] { 1, 3, 5, 7, 9 };
            foreach (int i in B)
            {
                count++;
                sum += i;
                Console.WriteLine($"The count is {count} and the sum is {sum}.");
                if (count == B.Length)
                {
                    mean = sum / count;
                    Console.WriteLine($"The mean for array B is {mean}");
                    mean = sum = count = 0;

                }
            }
            Console.WriteLine("");
        }

        private static void ArrayC()
        {
            int[] C = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            foreach (int i in C)
            {
                count++;
                sum += i;
                Console.WriteLine($"The count is {count} and the sum is {sum}.");
                if (count == C.Length)
                {
                    mean = sum / count;
                    Console.WriteLine($"The mean for array C is {mean}");
                    mean = sum = count = 0;
                }
            }
        }
    }
}
      



