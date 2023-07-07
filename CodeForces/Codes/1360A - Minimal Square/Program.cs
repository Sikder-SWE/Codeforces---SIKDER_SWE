using System;
using static System.Console;
public class Program
{
    public static void Main()
    {
        long test, a, b;
        test=long.Parse(ReadLine());
        while(test>0)
        {
            string[] input = ReadLine().Split(' ');
            a = long.Parse(input[0]);
            b = long.Parse(input[1]);
            if(a > b)
            {
               long temp = a; 
                a = b; 
                b = temp;
            }
            long result= Math.Max(a*2, b);
            WriteLine(result*result);
            test--;
        }

    }
}