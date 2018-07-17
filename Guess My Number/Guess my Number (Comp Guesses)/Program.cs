using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketableMesopotamianMonolith
{
    class Program
    {
        private static int iterations;
        private static int count;
        private static double average;        

        static void Main()
        {
            
            Console.WriteLine($"This is iteration {++iterations}");

            int[] list = Enumerable.Range(0, 1001).ToArray();//generates an array populated with numbers 0-1000

            Console.WriteLine($"Enter the number for the computer to guess.");
            int userNumber = int.Parse(Console.ReadLine());            

            bisection(list, userNumber);
        }

        private static void bisection(int[] selectionlist, int userNumber)
        {            
                int upperbound = selectionlist.GetUpperBound(0); //next four lines establish key places within a collection of elements to run the bisection algorithm
                int middlebound = upperbound / 2;
                int lowerbound = selectionlist.GetLowerBound(0);
                int middleNumber = selectionlist[middlebound];
               
                Random compGenerator = new Random();
                int compNumber = compGenerator.Next(selectionlist[lowerbound], selectionlist[upperbound]+1);//randomly selects a number between the range of the list            
                if (selectionlist[middlebound]==selectionlist[lowerbound])//added to account for redundancy of computer generated numbers when userNumber==upper or lower bounds of array.
                {
                compNumber = compNumber+1; 
                }
                else if (selectionlist[middlebound]==selectionlist[upperbound])
                {
                compNumber = compNumber - 1;
                }

                Console.WriteLine($"Attempt {++count}");
                Console.WriteLine($"The computer guessed {compNumber}");

                if (compNumber > userNumber)
                {
                    Console.WriteLine($"The guess was too high. The number is lower.\n");

                    if (userNumber <= middleNumber)
                    {
                        int[] lowerValues = new int[middlebound+1];

                        for (int i = 0; i < lowerValues.Length; i++)
                        {
                            lowerValues[i] = selectionlist[i];
                        }
                        bisection(lowerValues, userNumber);
                    }
                    else if (userNumber >= middleNumber)
                    {
                        int[] higherValues = new int[upperbound - middlebound + 1];
                        for (int i = 0; i < higherValues.Length; i++)
                        {
                            higherValues[i] = selectionlist[middlebound++];                        
                        }
                        bisection(higherValues, userNumber);
                    }
                }

                else if (compNumber < userNumber)
                {
                    Console.WriteLine($"The guess was too low. The number is higher.\n");

                    if (userNumber <= middleNumber)
                    {
                        int[] lowerValues = new int[middlebound+1];

                        for (int i = 0; i < lowerValues.Length; i++)
                        {
                            lowerValues[i] = selectionlist[i];
                        }
                        bisection(lowerValues, userNumber);
                    }
                    else if (userNumber >= middleNumber)
                    {
                        int[] higherValues = new int[upperbound - middlebound + 1];
                        for (int i = 0; i < higherValues.Length; i++)
                        {
                            higherValues[i] = selectionlist[middlebound++];                        
                        }
                        bisection(higherValues, userNumber);
                    }
                }

                else if (compNumber == userNumber)
                {
                    Console.WriteLine($"The computer guessed your number correctly. Your number is {userNumber}\n");
                    if (iterations == 5)
                    {
                        average = count / iterations;
                        Console.WriteLine($"The average amount of tries is {average}\n");
                        count = iterations = 0;//resets count and iterations after 5 complete iterations of the game.
                    }
                    Main();
                }
            }                    
    }
}
