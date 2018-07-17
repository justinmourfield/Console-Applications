using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the value of A.");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of B.");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of C.");
            double C = double.Parse(Console.ReadLine());

            double positiveForm = (-B +(Math.Sqrt (B*B-4*A*C)))/(2*A);
            Console.WriteLine($"X = {positiveForm}");
            double negativeForm = (-B - (Math.Sqrt(B * B - 4 * A * C))) / (2 * A);
            Console.WriteLine($"X = {negativeForm}");
            
        }
    }
}
