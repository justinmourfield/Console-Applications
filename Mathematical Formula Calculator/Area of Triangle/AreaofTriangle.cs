using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the side A.");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the side B.");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the side C.");
            int C = int.Parse(Console.ReadLine());
            int halfCircum = (A + B + C) / 2;

            double area = Math.Sqrt(halfCircum - A) * (halfCircum - B) * (halfCircum -C);
            Console.WriteLine($"The area of the triangle is {area}.");
        }
    }
}
