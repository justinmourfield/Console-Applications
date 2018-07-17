using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            Console.WriteLine("Please enter a number to convert.");
            Console.Write("Number:");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number's base.");
            Console.Write("Base:");
            int Base = int.Parse(Console.ReadLine());
            switch(Base)
            {
                case 10:
                    Console.WriteLine($"{DecimalToBinary(Number)}");
                    Console.WriteLine($"{DecimalToOctal(Number)}");
                    break;
                case 8:
                    Console.WriteLine($"{OctalToBinary(Number)}");
                    Console.WriteLine($"{OctalToDecimal(Number)}");
                    break;
                case 2:
                    Console.WriteLine($"{BinaryToDecimal(Number)}");
                    Console.WriteLine($"{BinaryToOctal(Number)}");
                    break;
            }
            Console.WriteLine("Do you want to convert another number? Yes or no?");
           string answer= Console.ReadLine().ToUpper();
            if(answer=="YES")
            {
                goto START;
            }
        }

        private static int DecimalToBinary(int Number)
        {
            int Result = 0;        
            int Factor = 1;
            while (Number > 0)
            {
                int i = Number % 2;
                Number = Number / 2;
                Result += i * Factor;
                Factor *= 10;
            }
            return Result;
        }

       private static int DecimalToOctal(int Number)
        {
            int Result = 0;
            int Factor = 1;
            while (Number > 0)
            {
                int i = Number % 8;
                Number = Number / 8;
                Result += i * Factor;
                Factor *= 10;
            }
            return Result;
        }

        private static int BinaryToDecimal(int Number)
        {
            double Result = 0;
            double Power = 0;
            while (Number > 0)
            {
                int i = Number % 10;
                double j = i * Math.Pow(2, Power);
                Result += j;
                Power++;            
                Number = Number / 10;
            }
            return (int)Result;
        }

       private static int BinaryToOctal(int Number)
        {
            int Result = 0;
            int Factor = 1;
            while (Number > 0)
            {
                int i = Number % 1000;
                int j = i % 10;
                int k = ((i / 10) % 10) * 2;
                int l = (i / 100) * 4;
                int m = j + k + l;
                Result += m * Factor;
                Factor *= 10;
                Number = Number / 1000;
            }
            return Result;
        }

       private static int OctalToBinary(int Number)
        {
            int j = 0;
            int k = 0;
            int Result = 0;
            int Factor = 1;
            while (Number > 0)
            {
                j = Number % 10;
                k = DecimalToBinary(j);
                Result += k * Factor;
                Factor *= 1000;
                Number = Number / 10;
            }
            return Result;
        }

        private static int OctalToDecimal(int Number)
        {
            double Result = 0;
            double Factor = 0;
            while (Number > 0)
            {
                int i = Number % 10;
                Result += (i * Math.Pow(8, Factor));
                Factor++;
                Number = Number / 10;
            }
            return (int)Result;
        }
    }
}
