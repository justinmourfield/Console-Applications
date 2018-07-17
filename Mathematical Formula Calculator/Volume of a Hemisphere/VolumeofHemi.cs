using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeofHemi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of the radius. ");
            double radiusValue = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double volume = (4 / 3) * pi * (radiusValue * radiusValue * radiusValue);
            Console.WriteLine($"The volume of the hemisphere is {volume}.");
        }
    }
}
