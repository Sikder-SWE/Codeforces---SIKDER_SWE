using System;
using static System.Console;

class Problem_581A
{
    public static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);

        int fashion = Math.Min(a, b);
        int max = Math.Max(a, b);

        Console.WriteLine(fashion + " " + (max - fashion) / 2);
    }
}