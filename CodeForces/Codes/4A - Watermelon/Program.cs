// problem link : https://codeforces.com/contest/4/problem/A
using System;

class Problem_4A
{
    static void Main()
    {
        int weight;
        weight = int.Parse(Console.ReadLine());
        if (weight > 2)
        {
            if (weight % 2 == 0)
            {
                if ((weight / 2) % 2 == 0 || weight / 2 != 1)
                {
                    Console.Write("YES");
                }

            }
            else
                Console.Write("NO");

        }
        else
            Console.Write("NO");

    }

}
