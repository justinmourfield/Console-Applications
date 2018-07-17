using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryption
{
    class Program
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        static string username;
        static string Password;

        static void Main()
        {
            try
            {
                START:
                Console.WriteLine("Enter 1 to create an account, 2 to verify an account, or 3 to exit the program.");
                int decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        createUser();
                        break;
                    case 2:
                        authenticateUser();
                        break;
                    case 3:
                        foreach (KeyValuePair<string, string> user in users)//upon exit all users & passwords are shown
                            Console.WriteLine(user);
                        break;
                    default:
                        Console.WriteLine("That was not a valid selection.");//if user enters numerics out of range
                        goto START;
                }
            }
            catch (FormatException)//if user enter alpha characters an exception is thrown
            {
                Console.WriteLine("Please enter 1, 2, or 3.");
                Main();
            }
        }

        private static void createUser()
        {
            START:
            Console.WriteLine("Please enter a username.");
            username = Console.ReadLine();
            if (users.ContainsKey(username))//prevents duplication of keys
            {
                Console.WriteLine("That username is unavailable. Please select a different username.");
                goto START;
            }
            users.Add(username, HashPassword().ToString());//adds username and string representation of hashed password
            Main();
        }

        private static void authenticateUser()
        {
            START:
            Console.WriteLine("Please enter a username.");
            username = Console.ReadLine();
            if (users.ContainsKey(username))
            {
                if (users.ContainsValue(HashPassword().ToString()))
                {
                    Console.WriteLine("User is authenticated");
                    Main();
                }
                else
                    Console.WriteLine("Incorrect password.");
                goto START;
            }
            else if (users.ContainsKey(username) == false)
            {
                Console.WriteLine("That username does not exist.");
                Main();
            }
        }

        private static string HashPassword()
        {
            Console.WriteLine("Please enter a password.");
            Password = Console.ReadLine();
            MD5 md5 = MD5.Create();
            byte[] encodedPassword = md5.ComputeHash(Encoding.UTF8.GetBytes(Password));//hashes the input password
            StringBuilder hashedPassword = new StringBuilder();
            for (int i = 0; i < encodedPassword.Length; i++)
            {
                hashedPassword.Append(encodedPassword[i].ToString("x2"));//created a string of the hash values
            }
            return hashedPassword.ToString();
        }
    }
}


