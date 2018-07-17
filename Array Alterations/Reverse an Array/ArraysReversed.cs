using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReveresed
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] A = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[5] { 1, 3, 5, 7, 9 };
            int[] C = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            ReverseArray(A);
            ReverseArray(B);
            ReverseArray(C);

        }

        private static void ReverseArray(int[] InputArray)
        {
            int j = 0;//j is the element of the array initialized to zero because array elements begin at 0.

            int count = -1;/* the count is used so in the event that there is an unknown amount of elements in an array, the section of code that 
            prints the array in reverse knows the numeric of the last element of the array. its -1 because the count is initialized to 0 but arrays have a
             base of 0 which would lead to a fence post error in regards to the highest element of the array.*/

            for (int iteration = 1; iteration < InputArray.Length + 1; iteration++)/*iteration begins at 1 to make keeping track of how many iterations have 
             taken place easier to understand. This would result in a fence post error if the length of the array is not increased by one.*/
            {
                int ArrayValue = InputArray[j++];// ArrayValue holds that value of the element starting at element 0.
                Console.WriteLine($"before reverse; Iteration {iteration}, value of array element is {ArrayValue}");
                count++;
            }
            Console.WriteLine("");//formatting

            int h = count; // uses the amount of iterations that took place counting up through the array to identify the amount of elements in the array
                           // this is used to count back down through the array starting at the highest element.

            for (int a = 1; a < InputArray.Length + 1; a++)
            {
                int arrayValue = InputArray[h--]; //counts down through the amount of elements in the array.
                Console.WriteLine($"after reverse; Iteration {a}, value of array element is {arrayValue}");
            }
            Console.WriteLine("");//formatting
        }
    }
}

         

