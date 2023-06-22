using System;
using static System.Console;

class Problem_427A
{
    public int Solution(int Event, string[] Events)
    {
        int Police = 0;
        int Untreated = 0;

        for (int i = 0; i < Events.Length; i++)
        {
            //WriteLine(Events[i]);
            if (Events[i] != "-1") Police += int.Parse(Events[i]);
            else
            {
                if (Police == 0)
                    Untreated++;
                else
                    Police--;
            }
        }
        return Untreated;
    }

    static void Main(string[] args)
    {
        int Event = int.Parse(Console.ReadLine());
        string[] Events = ReadLine().Split().ToArray();
        Problem_427A solve = new Problem_427A();
        //WriteLine(Events);
        WriteLine(solve.Solution(Event, Events));
    }
}
