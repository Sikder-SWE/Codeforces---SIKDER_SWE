using System;
using static System.Console;

class Problem_266A
{
    static void Main()
    {
        int TotalStones = int.Parse(ReadLine());    // I will store how many stones will be given
        string stones = ReadLine();                 // It will store color string to check for the program
        int RemovedStones = 0;                      // this variable will calculate how many stones can be removed form the string
                                                    //	WriteLine(stones);
        if (TotalStones > 1)
        {
            for (int i = 0; i <= (stones.Length) - 2; i++)
            {
                if (stones[i] == stones[i + 1])     // this is accroding to program statement:: logic
                {
                    RemovedStones++;
                    continue;
                }
                else
                {
                    continue;
                }
            }
            WriteLine(RemovedStones);
        }
        else
        {
            WriteLine(0);
        }
    }
}