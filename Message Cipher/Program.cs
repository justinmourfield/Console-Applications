using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a string that consists of letters only");

            string input = Console.ReadLine();

            Console.WriteLine(Encrypt1(input));

            Console.WriteLine(Encrypt2(input));

            Console.WriteLine(Encrypt3(input));

            Console.ReadLine();
        }



        public static string Encrypt1(string input)
        {           
            input = input.ToUpper();

            StringBuilder result = new StringBuilder();

            foreach (char letter in input)
            {
                int temp = letter;
                temp += 3;

                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);
            }
            return result.ToString();
        }



        public static string Encrypt2(string input)
        {
            string cipher = "TRY";

            input = input.ToUpper();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i];
                temp += cipher[i % cipher.Length] - 60;
                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);            
            }        
            return result.ToString();
        }



        public static string Encrypt3(string input)
        {
            input = input.ToUpper();
            string cipher = "TRY" + input;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i];
                temp += cipher[i % cipher.Length] - 60;
                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);
            }
            return result.ToString();
        }
    }
}
