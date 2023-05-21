using System;
using System.Globalization;
using static System.Console;

class Problem1154A
{
    int[] Restore(int[] Numbers)
    {
        Array.Sort(Numbers);
        int Sum_abc = Numbers[Numbers.Length-1];
        //WriteLine(Sum_abc);
        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            Numbers[i] = Sum_abc - Numbers[i];
            //Write($"{Numbers[i]} ");  //Debugged
        }
        return Numbers;
    }
    static void Main()
    {
        int[] Integers = Array.ConvertAll(ReadLine().Split(), int.Parse);

        Problem1154A solution = new Problem1154A();
        int[] Numbers = solution.Restore(Integers);
        Write($"{Numbers[0]} {Numbers[1]} {Numbers[2]}");
    }
}