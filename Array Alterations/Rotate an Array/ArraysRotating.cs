using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRotating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                START:
                int[] ArrayA = new int[5] { 5, 10, 15, 20, 25 };

                Console.WriteLine("How many places do you want to shift the array?");
                int offset = int.Parse(Console.ReadLine()); //offset is used to specify what element to begin the copy from InputArray to ShiftedArray
                if (offset > ArrayA.Length)
                {
                    Console.WriteLine("You must enter a number that is within the range of Array values. Please try again.");
                    goto START;
                }             
            Console.WriteLine("What direction do you want to shift the array?");//Find out if you need to shift values left or right
            string direction = Console.ReadLine();
            if (direction == "left")
            {
                ShiftLeft(ArrayA, direction, offset);
            }

            else if (direction == "right")
            {
                ShiftRight(ArrayA, direction, offset);
            }
            else
            {
                Console.WriteLine("I did not recognize that direction.");
                goto START;
            }
            }
            catch (FormatException ForMat)
            {
                Console.WriteLine($"{ForMat.Message}");                
            }

        }



        private static void ShiftRight(int[] InputArray, string direction, int offset)
        {
            int[] ShiftedArray = new int[InputArray.Length];
            int nextvalue = offset;
            int iterations = 0;
            for (int i = 0; i < ShiftedArray.Length - offset; i++)
            {
                ShiftedArray[nextvalue] = InputArray[i];
                Console.WriteLine("");
                nextvalue++;
                iterations++;
            }
            int RemainingValues = iterations;//remaining values is equivalent to the amount of iterations because the iterations stopped at the highest 
            //value that was assigned to the ShiftedArray. 


            for (int j = 0; j < InputArray.Length - iterations; j++)
            //j works to assign values to remaining blanks when combined because you subtract the amount of
            //times values have been assigned to the ShiftedArray from the length leaving the remaining blank array values. j starts at the beginning and 
            //works its way towards the end of the array but stops before overwriting values that have already been created.
            {
                ShiftedArray[j] = InputArray[RemainingValues++]; 
            }
            Console.Write("The new order of the array is: ");
            foreach (int i in ShiftedArray)
            {
                Console.Write($"{i} ");
            }
        }

        private static void ShiftLeft(int[] InputArray, string direction, int offset)
        {
            int[] ShiftedArray = new int[InputArray.Length];//sets the length of the Array that will hold the copied values to the same length as the original
            int ArrayElement = 0; // used to determine the amount of elements in the array.
            foreach (int i in InputArray)
            {
                ArrayElement++;
            }

            int elementshifted = ArrayElement - offset;
 // x = y - z (x is the spot to begin inserting values) (y is the upper limit of array) (z is the number of spots being shifted.)

            int nextvalue =0;// used in place of "i" to keep track of what elemtent the InputArray ended on so that the 2nd loop can start at this same element.

            for (int i = 0; i < offset; i++)//GOOD TO GO on proper iterations 
            {
                ShiftedArray[elementshifted] = InputArray[i]; // assigns the proper values to the proper spots
                Console.WriteLine("");//formatting
                elementshifted++;//selects the next element of the ShiftedArray to recieve new values.
                ArrayElement--;// Used to have a starting point for the remaining values to be copied in the next for loop. 
                nextvalue++;//increased the same way InputArray[i] is incremented.
            }
            int RemainingValues = ArrayElement-1;//minus 1 to account for fence post issues.
            int PastIterations = nextvalue;// Past iterations is equal to the amount of times the nextvalue has been incrememented.  

            for (int j = 0; j < InputArray.Length - PastIterations; j++)
// if j< x-y continue loop; (x being the length of the array) (y being the amount of iterations through the array that have already taken place)
// This loopfills in the remaining values of the array that did not recieve a new copied value.
            {
                ShiftedArray[RemainingValues--] = InputArray[nextvalue++];  
            }
            //The next 5 lines print the shifted array to screen in order.
            Console.Write("The new order of the array is: ");
            foreach(int i in ShiftedArray)
            {
                Console.Write($"{i} ");
            }
        }
    }
} 


    

