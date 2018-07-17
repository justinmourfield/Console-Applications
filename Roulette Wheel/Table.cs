using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roullette
{
    partial class Table
    {

        public static void determineBets(int selectedColor, string stringNumber)
        {
            int selectedNumber = int.Parse(stringNumber);
            int[,] rouletteTable = maketable();

            specificNumber(selectedNumber);
            lowsHighs(selectedNumber);
            redBlack(selectedColor);
            evensOdds(selectedNumber);
            dozens(selectedNumber);
            columns(selectedNumber, rouletteTable);
            rows(selectedNumber, rouletteTable);
            doublerows(selectedNumber, rouletteTable);
            split(selectedNumber, rouletteTable);
            Corner(selectedNumber, rouletteTable);
        }

        private static int[,] maketable()//creates and populates a Roulette table with number 1-36 to be used for betting.
        {
            int[,] rouletteTable = new int[12, 3];
            int k = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rouletteTable[i, j] = k;
                    k++;
                }
            }
            return rouletteTable;
        }

        private static void TopRightCorner(int selectedNumber, int[,] rouletteTable)//Populates all numbers that touch the top right corner of the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The winning top right corner bets are {selectedNumber}, {rouletteTable[x, y+1]}, {rouletteTable[x - 1, y]}," +
                            $" and {rouletteTable[x - 1, y+1]}");
                    }
                }
            }
        }

        private static void TopLeftCorner(int selectedNumber, int[,] rouletteTable)//Populates all numbers that touch the top left corner of the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The winning top left corner bets are {selectedNumber}, {rouletteTable[x, y - 1]}, {rouletteTable[x - 1, y]}, " +
                            $"and {rouletteTable[x - 1, y - 1]}");
                    }
                }
            }
        }

        private static void BottomRightCorner(int selectedNumber, int[,] rouletteTable)//Populates all numbers that touch the bottom right corner of the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The winning bottom right corner bets are {selectedNumber}, {rouletteTable[x, y + 1]}, {rouletteTable[x + 1, y]}, " +
                            $"and {rouletteTable[x + 1, y + 1]}");
                    }
                }
            }
        }

        private static void BottomLeftCorner(int selectedNumber, int[,] rouletteTable)//Populates all numbers that touch the bottom left corner of the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The winning bottom left corner bets are {selectedNumber}, {rouletteTable[x, y - 1]}, {rouletteTable[x + 1, y]}, " +
                            $"and {rouletteTable[x + 1, y - 1]}");
                    }
                }
            }
        }
        private static void TopSplit(int selectedNumber, int[,] rouletteTable)//Populates the number that shares the top border with the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The split on {selectedNumber} and {rouletteTable[x+1, y]} win.");
                    }
                }
            }
        }
        private static void BottomSplit(int selectedNumber, int[,] rouletteTable)//Populates the number that shares the bottom border with the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The split on {selectedNumber} and {rouletteTable[x-1, y]} win.");
                    }
                }
            }
        }
        private static void LeftSplit(int selectedNumber, int[,] rouletteTable)//Populates the number that shares the left border with the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The split on {selectedNumber} and {rouletteTable[x, y-1]} win.");
                    }
                }
            }
        }
        private static void RightSplit(int selectedNumber, int[,] rouletteTable)//Populates the number that shares the right border with the selected number
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (selectedNumber == rouletteTable[x, y])
                    {
                        Console.WriteLine($"The split on {selectedNumber} and {rouletteTable[x, y+1]} win.");
                    }
                }
            }
        }
    } 
}





    

 