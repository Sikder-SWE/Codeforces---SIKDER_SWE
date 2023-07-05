using System;

class Problem_479A
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = a + b + c;

        if (max < (a + b) * c)
        {
            max = (a + b) * c;
        }
        if (max < a * (b + c))
        {
            max = a * (b + c);
        }
        if (max < a * b * c)
        {
            max = a * b * c;
        }

        Console.Write(max);
    }
}