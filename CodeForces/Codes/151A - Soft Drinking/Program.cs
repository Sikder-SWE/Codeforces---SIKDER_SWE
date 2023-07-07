using System;
using static System.Console;

class Program_151A
{
    static void Main()
    {
        int[] ingredients = Array.ConvertAll(ReadLine().Split(), int.Parse);

        int[] element = {((ingredients[1]*ingredients[2])/ingredients[6])/ingredients[0],(ingredients[3]*ingredients[4])/ingredients[0],(ingredients[5]/ingredients[7])/ingredients[0]};
       int temp = element[0];
       foreach(int entry in element)
       {
           if(entry<temp)
           temp = entry;
           else
           continue;
       }
        WriteLine($"{temp}");
    }
}