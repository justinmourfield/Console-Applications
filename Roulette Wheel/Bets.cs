using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roullette
{
    partial class Table
    {

        private static void specificNumber(int selectedNumber)//specifies what number wins bet
        {
            Console.WriteLine($"All bets on {selectedNumber} win.");
        }

        private static void evensOdds(int selectedNumber)//determines if even or odd numbers win bet
        {
            int[] even = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            if (even.Contains(selectedNumber))
            {
                Console.WriteLine("Even bets win.");
            }
            else if (selectedNumber == 00 || selectedNumber == 0)
            {

            }
            else
                Console.WriteLine("Odd bets win");
        }

        private static void redBlack(int selectedColor)//determines what color wins bet
        {
            if (selectedColor == 1)
            {
                Console.WriteLine("All bets on red won.");
            }
            else if (selectedColor == 2)
            {
                Console.WriteLine("All bets on black won.");
            }
        }

        private static void lowsHighs(int selectedNumber)//determines whether low or high numbers win bet
        {
            if (selectedNumber > 0 && selectedNumber <= 18)
            {
                Console.WriteLine("Low bets win.");
            }
            else if (selectedNumber >= 19 && selectedNumber < 36)
            {
                Console.WriteLine("High bets win.");
            }
            //*1
        }

        private static void dozens(int selectedNumber)//determines what dozen of numbers wins bet
        {
            if (selectedNumber <= 12)
            {
                Console.WriteLine("Bets in the 1st dozen win.");
            }
            else if (selectedNumber <= 24)
            {
                Console.WriteLine("Bets in the 2nd dozen win.");
            }
            else
                Console.WriteLine("Bets in the 3rd dozen win.");
        }

        private static void columns(int selectedNumber, int[,] rouletteTable)//determines what column wins bet
        {

            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"Bets on column {y + 1} win");
                    }
                }
            }
        }

        private static void rows(int selectedNumber, int[,] rouletteTable)//determines what row wins bet
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"Bets on row {x + 1} win");
                    }
                }
            }

        }

        private static void doublerows(int selectedNumber, int[,] rouletteTable)//determines what double rows win bet
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        if (x > 2 && x < 12)
                        {
                            Console.WriteLine($"The winning rows are { x + 1} and { x + 2}");
                        }
                    }
                }
            }
        }

        private static void split(int selectedNumber, int[,] rouletteTable)
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])// finds the x,y "coordinates" of the number within the routlete table
                    {
                        if (x == 0 && y == 0) // if statements accounts for constraints if number is within the first row
                        {
                            RightSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                        }
                        else if (x == 0 && y == 1)
                        {
                            LeftSplit(selectedNumber, rouletteTable);
                            RightSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                        }
                        else if (x == 0 && y == 2)
                        {
                            LeftSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                        }

                        if (x != 0 && x != 11 && y == 0)//accounts for constraints if number is in outer columns or inner columns and not within the 1st or last row 
                        {
                            TopSplit(selectedNumber, rouletteTable);
                            RightSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                        }
                        else if (x != 0 && x != 11 && y == 1)
                        {
                            TopSplit(selectedNumber, rouletteTable);
                            RightSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                            LeftSplit(selectedNumber, rouletteTable);
                        }
                        else if (x != 0 && x != 11 && y == 2)
                        {
                            TopSplit(selectedNumber, rouletteTable);
                            LeftSplit(selectedNumber, rouletteTable);
                            BottomSplit(selectedNumber, rouletteTable);
                        }

                        if (x == 11 && y == 0) // accounts for constraints if number is within the last row 
                        {
                            TopSplit(selectedNumber, rouletteTable);
                            RightSplit(selectedNumber, rouletteTable);
                        }
                        else if (x == 11 && y == 1)
                        {
                            LeftSplit(selectedNumber, rouletteTable);
                            TopSplit(selectedNumber, rouletteTable);
                            RightSplit(selectedNumber, rouletteTable);
                        }
                        else if (x == 11 && y == 2)
                        {
                            TopSplit(selectedNumber, rouletteTable);
                            LeftSplit(selectedNumber, rouletteTable);
                        }
                    }
                }
            }
        }
        private static void Corner(int selectedNumber, int[,] rouletteTable)
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])// finds the x,y "coordinates" of the number within the routlete table
                    {
                        if (x == 0 && y == 0) // if statements accounts for constraints if number is within the first row
                        {
                            BottomRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x == 0 && y == 1)
                        {
                            BottomLeftCorner(selectedNumber, rouletteTable);
                            BottomRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x == 0 && y == 2)
                        {
                            BottomLeftCorner(selectedNumber, rouletteTable);
                        }

                        if (x != 0 && x != 11 && y == 0)//accounts for constraints if number is in outer columns or inner columns and not within the 1st or last row 
                        {
                            TopRightCorner(selectedNumber, rouletteTable);
                            BottomRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x != 0 && x != 11 && y == 1)
                        {
                            TopLeftCorner(selectedNumber, rouletteTable);
                            TopRightCorner(selectedNumber, rouletteTable);
                            BottomLeftCorner(selectedNumber, rouletteTable);
                            BottomRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x != 0 && x != 11 && y == 2)
                        {
                            TopLeftCorner(selectedNumber, rouletteTable);
                            BottomLeftCorner(selectedNumber, rouletteTable);
                        }

                        if (x == 11 && y == 0) // accounts for constraints if number is within the last row 
                        {
                            TopRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x == 11 && y == 1)
                        {
                            TopLeftCorner(selectedNumber, rouletteTable);
                            TopRightCorner(selectedNumber, rouletteTable);
                        }
                        else if (x == 11 && y == 2)
                        {
                            TopLeftCorner(selectedNumber, rouletteTable);
                        }
                    }
                }
            }
        }
    }
}

