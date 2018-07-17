using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSpecific
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine grade.");
            int count = 0;   
            double sum = 0;
            Console.WriteLine("How many test scores do you need to average.");
            int tests = int.Parse(Console.ReadLine());
            GetSum();

                void GetSum()
                {   
                count++;
                Console.WriteLine($"Enter test grade number {count}");
                sum += double.Parse(Console.ReadLine());
                
                if (count < tests)
                {
                    GetSum();
                }

                else if (count==tests)
                {
                CalculatedAverage();
                }
                else
                {
                    return;
                }
                

                    void CalculatedAverage()
                    {
                        double Average = sum / tests;

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

