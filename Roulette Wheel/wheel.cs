using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roullette
{
    class Wheel
    {
        public Wheel()//constructor
        {

        }

        public void getnumber()//array of colors that correspond to numbers on roulette table
        {
            string[] Colors = new string[3] { "green", "red", "black", };
            int color = 0;
            Random pickcolor = new Random();
            for (int i = 0; i < 30; i++)
            {
                color = pickcolor.Next(0, 3);
            }

            //array of numbers that correspond to each color with built in redundancy to decreased odds of over populations of the same number
            string[][] tableNumbers = new string[3][]; 
            tableNumbers[0] = new string[18] { "0", "00", "0", "00", "0", "00", "0", "00", "0", "00", "0", "00", "0", "00", "0", "00", "0", "00" }; 
            tableNumbers[1] = new string[36] { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19",
                    "21", "23", "25", "27", "30", "32", "34", "36", "1", "3", "5", "7", "9", "12", "14", "16", "18", "19",
                    "21", "23", "25", "27", "30", "32", "34", "36" };
            tableNumbers[2] = new string[36] { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20",
                    "22", "24", "26", "28", "29", "31", "33", "35", "2", "4", "6", "8", "10", "11", "13", "15", "17", "20",
                    "22", "24", "26", "28", "29", "31", "33", "35" };

            //the number selected by "pickcolor" is used to queue a number to be selected that corresponds to that color
            if (color == 0)
            {

                Random redundancy = new Random();
                int doubleredundancy = redundancy.Next(0, 3);

                if (doubleredundancy == 0)//second layer of redundancy to avoid overpopulation of 0 && 00
                {

                    int greennumber = 0;
                    Random green = new Random();

                    for (int i = 0; i < 30; i++)
                    {
                        greennumber = green.Next(0, 18); //selects number from corresponding Colors[] with 9 sets of redundancy    
                    }

                    Console.WriteLine($"green {tableNumbers[color][greennumber]}");
                    Table.determineBets(color, tableNumbers[color][greennumber]); //calls the method to determine what bets won
                }
                    else if (doubleredundancy != 0)
                    {
                        color = doubleredundancy;
                    }
            }
            
                         if (color == 1)
                        {
                            int rednumber = 0;
                            Random red = new Random();
                            for (int i = 0; i < 30; i++)
                            {
                                rednumber = red.Next(0, 36); 
                            } 
                            Table.determineBets(color,tableNumbers[color][rednumber] ); /*color that was selected, number that was selected*/


            }
                                else if (color == 2)
                                {
                                    int blacknumber = 0;
                                    Random black = new Random();
                                    for (int i = 0; i < 30; i++)
                                    {
                                         blacknumber=black.Next(0, 36); 
                                    }
                                    Table.determineBets(color, tableNumbers[color][blacknumber]);
            }
                
        }

    }
}
