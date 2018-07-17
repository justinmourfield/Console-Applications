using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistical_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            STARTAGAIN:

            Console.WriteLine("Enter a number between 10 - 1000");
            int n = int.Parse(Console.ReadLine());
            List<int> Zeroth = RandomList(n);
            foreach (int num in Zeroth)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine();

            int avg = Mean(Zeroth);
            Console.WriteLine("The mean of the list is {0}", avg);

            double med = Median(Zeroth);        
            Console.WriteLine("The median of the list is {0}", med);

            int sd = StandardDeviation(Zeroth);

            Console.WriteLine($"The standard deviation is {sd}");

            double mAD = MedianAD(Zeroth);
            Console.WriteLine($"The median absolute deviation is {mAD}"); 
            
            double skew = Skewness(Zeroth);
            Console.WriteLine($"The Skewness is {skew}");
            
            double kurt = Kurtosis(Zeroth);
            Console.WriteLine($"The Kurtosis is {kurt}");

            Console.WriteLine("Enter 1 to run this program again with another random list");

            string restart = Console.ReadLine();

            if (restart == "1")
            {
                goto STARTAGAIN;
            }
        }

        public static List<int> RandomList(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(new Random(i).Next(1000));
            }
            return result;
        }

        public static int Mean(List<int> intList)
        {
            return (int)intList.Average();
        }

        public static double Median(List<int> intList)
        {
            intList.Sort();

            // integer division requires the addition of one to get the midpoint

            if (intList.Count % 2 != 0)
            {
                return (intList[intList.Count / 2 + 1]);
            }
            {
                double half1 = intList[intList.Count / 2];
                double half2 = intList[intList.Count / 2 + 1];
               return (half1 + half2) / 2;
            }        
        }

        // method to get the standard deviation of a list of integers

        public static int StandardDeviation(List<int> intList)
        {
            List<int> numerator = new List<int>();
            double median = Median(intList);
            double average = Mean(intList);

            foreach (int num in intList)
            {
                int temp = (int)(Math.Pow(num - average, 2));
                numerator.Add(temp);
            }
            int total = numerator.Sum();
            return (int)Math.Sqrt(total / intList.Count);
        }

        // method get the median absolute deviation

        public static double MedianAD(List<int> intList)
        {
            intList.Sort();
            double median = Median(intList);
            List<int> absList = new List<int>();

            foreach (int num in intList)
            {
                absList.Add((int)Math.Abs(num - median));
            }
            return Median(absList);
        }

        // method calculates skewness of an integer list

        public static double Skewness(List<int> intList)
        {
            return (3 * (Mean(intList) - Median(intList)) / StandardDeviation(intList));
        }

        // method calculates the kurtosis of an integer list

        public static double Kurtosis(List<int> intList)
        {
            List<double> numerator = new List<double>();                        

            foreach (int num in intList)
            {
                numerator.Add(Math.Pow((num - Mean(intList)), 4));
            }
            double total = numerator.Sum();
            double lastNumerator = total / intList.Count;           
            double denominator = Math.Pow(StandardDeviation(intList), 4);
            return lastNumerator / denominator;
        }
    }
}
