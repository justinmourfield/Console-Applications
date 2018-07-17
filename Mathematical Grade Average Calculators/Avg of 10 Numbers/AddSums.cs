using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 10 integers.");
            int sum = 0;
            int count = 0;
            getsums();
            Console.WriteLine($"The sum is {sum}.");

            void getsums()
            {
                count++;
                Console.WriteLine($"The integer count is {count}:");
                sum += int.Parse(Console.ReadLine());
                if (count < 10)
                    getsums();
                else
                    return;
            }
        }
    }
}
