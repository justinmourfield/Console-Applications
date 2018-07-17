using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputArray = new int[10] {1, 3, 4, 6, 5, 2, 7, 8, 10, 9};
            int[] NewArray = new int[11] {10, 45, 80, 30, 20, 60, 40, 20, 60, 10, 100,  };
            SortArray(NewArray);
           
        }
        private static void SortArray(int[] InputArray)
        {

            
            for (int i = 0; i < InputArray.Length; i++)
            {
                for (int j = 0; j < InputArray.Length-1; j++)
                {
                    if (InputArray[j] > InputArray[j + 1])
                    {
                        int highervalue = InputArray[j];
                        InputArray[j] = InputArray[j + 1];
                        InputArray[j + 1] = highervalue;
 
                    }
                    
                }
                

            }
            for (int j = 0; j < InputArray.Length; j++)
            {
                Console.WriteLine(InputArray[j]);
            }

        }
        
    }
    
}
