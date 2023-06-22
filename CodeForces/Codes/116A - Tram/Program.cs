// Problem Link : https://codeforces.com/problemset/problem/116/A

using System;
using static System.Console;

public class Program
{
    static void Main()
    {
        int Test_stopage = int.Parse(ReadLine());

        int Rp = 0, Ep, Lp = 0, Capacity = 0;
        while (Test_stopage > 0)
        {
            Test_stopage--;
            int[] Passenger = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            Ep = Passenger[0]; Lp = Passenger[1];
            Rp = Rp + (Lp - Ep);

            Capacity = Capacity > Rp ? Capacity : Rp;
        }
        WriteLine(Capacity);
    }
}