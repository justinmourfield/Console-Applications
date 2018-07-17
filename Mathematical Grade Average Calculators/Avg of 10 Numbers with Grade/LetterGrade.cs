using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterGrade
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Determine your letter grade.");
            int count = 0;
            double sum = 0;
            CalculatedAverage();
 
                void CalculatedAverage()
                {
                    
                    GetSum();
                    double Average = sum / 10;
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

                    void GetSum()
                    {

                        count++;
                        Console.WriteLine($"Enter your grades. Grade number {count}.");
                        sum += double.Parse(Console.ReadLine());
                        if (count < 10)
                        {
                            GetSum();
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

    