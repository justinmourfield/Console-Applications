using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace SanFranFoodTrucks
{
    class Program
    {
        private static List<FoodTruck> listOfTrucks;
        private static IEnumerable<FoodTruck> availableTrucks;        

        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************\n" +

                    "***************************************************\n" +

                    "*         San Francisco Food Truck Finder         *\n" +

                    "*                    Program                      *\n" +

                    "***************************************************\n" +

                    "***************************************************\n");
        
            START:
            string ApiUrl = "https://data.sfgov.org/resource/bbb8-hzi6.json?$select=DayOfWeekStr,Applicant,starttime,endtime,location&$order=applicant&$limit=4000&$$app_token=chiJq7SjgXz5o7HrDCG55kyDH";
            WebClient connection = new WebClient();
            try
            {
                using (connection) //Establishes connection to server, downloads the JSON as a string, Parses the returned JSON into individual FoodTruck Objects and adds them to a collection.
                {
                    string results = connection.DownloadString(ApiUrl);
                    listOfTrucks = JsonConvert.DeserializeObject<List<FoodTruck>>(results);
                    connection.Dispose();
                }
                FindTrucks();
                DisplayTrucks();
            }
            catch (WebException WebEx) //Handles exceptions and allows users to retry the program without having to exit and reopen
            {
                Console.WriteLine($"I'm sorry. The following error occured, {WebEx.Message}. Would you like to try again. Please enter yes or no.");
                string response = Console.ReadLine().ToUpper();
                if (response == "YES")
                {
                    goto START;
                }                
                else
                {
                    DisplayThankYou();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"I'm sorry. An error occured. Would you like to try again? Please enter yes or no.");
                string response = Console.ReadLine().ToUpper();
                if (response == "YES")
                {
                    goto START;
                }                
                else
                {
                    DisplayThankYou();
                }
            }
            finally
            {
                connection.Dispose();
                if(listOfTrucks!=null)
                {
                  listOfTrucks.Clear();
                }
            }
        }

        //Search the collection of FoodTrucks using the system time and day as the search predicate within a LINQ query.
        //Trucks that are open during the specified system time and day are added to a collection to be populated 
        private static void FindTrucks()
        {
            DateTime hour = DateTime.Now;
            string day = DateTime.Now.DayOfWeek.ToString();

            availableTrucks = from truck in listOfTrucks
                              where truck.DayOfWeekStr.Contains(day)
                                && hour > DateTime.Parse(truck.Starttime)
                                && hour < DateTime.Parse(truck.Endtime)
                              select truck;
        }

        //Displays the Food Trucks that are currently open alphabetically sorted and in sets of 10. 
        //Options for users to show the next 10 trucks, previous 10 as well as exit the program are provided.
        private static void DisplayTrucks()
        {
            int count = availableTrucks.Count();

            if (count == 0)
            {
                Console.WriteLine("I'm sorry, but all the food trucks in your area are currently closed. Press any key to exit.");
                Console.ReadKey();
                DisplayThankYou();
            }
            else
            {
                Console.WriteLine("The Food Trucks currently open are listed below.\nName\t \t \t  Address");
            }

            int offset = 10;

            for (int i = 0; i <= count-1; i++)
            {
                Console.WriteLine($"{availableTrucks.ElementAt(i).Applicant.PadRight(25)} {availableTrucks.ElementAt(i).Location.PadRight(25)}");
                
                if ((i + 1) % 10 == 0)
                {
                    PROMPT:
                    Console.WriteLine("Enter 'Next' to see the next page, 'Previous' to view the previous page or 'Exit' if you're done.");
                    string answer = Console.ReadLine().ToUpper();
                    
                    if (answer == "NEXT")
                    {
                        offset = 20;
                    }
                    else if (answer == "PREVIOUS" && i < 10)
                    {
                        offset = 10;
                        i -= offset;
                    }
                    else if (answer == "PREVIOUS" && i > 10)
                    {
                        i -= offset;
                    }
                    else if (answer == "EXIT")
                    {
                        DisplayThankYou();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your response was not in the proper format. Please try again.");
                        goto PROMPT;
                    }
                }
                else if (i == count - 1 && count < 10)
                {
                    Console.WriteLine("There are no more trucks to display. Press any key to exit.");
                    Console.ReadKey();
                    DisplayThankYou();                    
                }
                else if(i==count-1)
                {
                    Console.WriteLine("\n You have reached the end of the list. For your convenience this list has been restarted from the beginning.\n");
                    i = -1; //set to negative one to account for increment that takes place after conditional statement execution and restart the list at index 0. 
                    //break;
                }                
            }
        } 
        private static void DisplayThankYou()
        {            
            Console.WriteLine("Thank you for using The San Francisco Food Truck Finder Program. Have a nice day!");
            Thread.Sleep(3000);
        }
    }
}
    