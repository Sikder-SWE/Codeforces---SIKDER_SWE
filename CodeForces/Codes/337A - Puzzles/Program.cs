using System;
using static System.Console;

class Problem_337A
{
    public Problem_337A(int[] pieces,int Last)
    {
        int difference = 996;
        //Array.Sort(pieces);
        for (int i = 0; i < pieces.Length - 1; i++)
        {
            if (Math.Abs(pieces[i + 1] - pieces[i]) < difference)
                difference = pieces[i + 1] - pieces[i];
            else
                continue;

        }
        Write(difference);
    }


    static void Main()
    {
        int[] nm = Array.ConvertAll(ReadLine().Split(),int.Parse);

        int[] pieces = Array.ConvertAll(ReadLine().Split(), int.Parse);

        Problem_337A solver = new Problem_337A(pieces, nm[0]);
    }
}