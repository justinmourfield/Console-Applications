using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNonSpecific
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will allow you to enter any number of test scores to be averaged and report the letter grade back.");
            Console.WriteLine("");
            
            int count = 0;
            double sum = 0;
            getTestScores();

            void getTestScores()
            {
                count++;
                Console.WriteLine($"Please enter test score {count}.");
                sum += double.Parse(Console.ReadLine());
                prompt();

                void prompt()
                {
                    Console.WriteLine("do you have more scores? Y/N");
                    if (Console.ReadLine() == "Y")
                    {
                        getTestScores();
                    } 
                    else
                    {
                        calculatedAverage();
                    }

                    void calculatedAverage()
                    {
                        double Average = sum / count;
                        Console.WriteLine($"The average is {Average}.");
                        if (Average <= 64)
                        {
                            Console.WriteLine("Your Grade is a F.");
                        }
                        else if (Average >= 65 && Average <= 73)
                        {
                            Console.WriteLine("Your Grade is a D.");
                        }
                        else if (Average >= 74 && Average <= 82)
                        {
                            Console.WriteLine("Your Grade is a C.");
                        }

                        else if (Average >= 83 && Average <= 91)
                        {
                            Console.WriteLine("Your Grade is a B.");
                        }

                        else if (Average >= 92)
                        {
                            Console.WriteLine("Your Grade is an A.");
                        }
                        else
                        {
                            return;
                        }

                    }
                }
            }
        }

    }
}
/* Console.WriteLine("Type END when after entering the last score to receive the average and grade.");
             Console.WriteLine("");*/
/*getTestScores();
                  }


                  if (double.Parse(Console.ReadLine()) != (1 - 100))
                  {
                      calculatedAverage();
                  }
                  else if(double.Parse(Console.ReadLine()) >1 && < 1)
                  {
                      return;   
                  }
                  */
