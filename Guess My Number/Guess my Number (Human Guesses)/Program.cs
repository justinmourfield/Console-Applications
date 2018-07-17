using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaggeringStegosaurusSoliloquy
{
    class Program
    {
       private static int iterations=0;
       private static int count;
        private static double average;

        static void Main()
        {            
            Console.WriteLine($"This is iteration {++iterations}");
            int[] list = Enumerable.Range(0, 1001).ToArray();//generates an array populated with numbers 0-1000
            Random compGenerator = new Random();
            int compNumber = compGenerator.Next(0, 1000);//randomly selects a number between 0-1000
            bisection(list, compNumber);
        }

        private static void bisection(int[] selectionlist, int compNumber)
        {
            int upperbound = selectionlist.GetUpperBound(0); //next four lines establish key places within a collection of elements to run the bisection algorithm
            int middlebound = upperbound / 2;
            int lowerbound = selectionlist.GetLowerBound(0);
            int middleNumber = selectionlist[middlebound];

            Console.WriteLine($"Attempt {++count}");
            Console.WriteLine($"Enter your guess. The range of numbers is available is from {selectionlist[lowerbound]} and {selectionlist[upperbound]}");
           int number = int.Parse(Console.ReadLine());

            if(number>compNumber)
            {
                Console.WriteLine($"Your guess was too high. The number is lower.\n");

                if (compNumber < middleNumber)
                {
                    int[] lowerValues = new int[middlebound];

                    for (int i = 0; i < lowerValues.Length; i++)
                    {
                        lowerValues[i] = selectionlist[i];
                    }
                    bisection(lowerValues, compNumber);
                }
                else if (compNumber > middleNumber)
                {
                    int[] higherValues = new int[upperbound - middlebound];
                    for (int i = 0; i < higherValues.Length; i++)
                    {
                        higherValues[i] = selectionlist[++middlebound];
                    }
                    bisection(higherValues, compNumber);
                }
            }

            else if (number<compNumber)
            {
                Console.WriteLine($"Your guess was too low. The number is highern \n");

                if (compNumber < middleNumber)
                {
                    int[] lowerValues = new int[middlebound];

                    for (int i = 0; i < lowerValues.Length; i++)
                    {
                        lowerValues[i] = selectionlist[i];
                    }
                    bisection(lowerValues, compNumber);
                }
                else if (compNumber > middleNumber)
                {
                    int[] higherValues = new int[upperbound - middlebound];
                    for (int i = 0; i < higherValues.Length; i++)
                    {
                        higherValues[i] = selectionlist[++middlebound];
                    }
                    bisection(higherValues, compNumber);
                }
            }    
            
            else if (number == compNumber)
            {
                Console.WriteLine($"Congratulations! You are right. The number is {compNumber}\n");
                if (iterations == 5)
                {
                    average = count / iterations;
                    Console.WriteLine($"The average amount of tries is {average}\n");
                    iterations = 0;
                }                
                Main();                               
            }

            else if(compNumber==middleNumber)
            {
                Console.WriteLine("I'm sorry, you lost. you ran out of guesses.\n");
            }

        }
    }
}
