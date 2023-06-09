using System;
using static System.Console;

class Problem_469A
{
    public string Solve(int totalLevels, int[] Xpasses, int[] LxPasses)
    {

        /*int totalLevels = int.Parse(Console.ReadLine());

        int[] Xpasses = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int[] LxPasses = Array.ConvertAll(ReadLine().Split(), int.Parse);
*/

        List<int> passedLevels = new List<int>();

        for (int i = 1; i < Xpasses.Length; i++)
            passedLevels.Add(Xpasses[i]);

        for (int i = 1; i < LxPasses.Length; i++)
            passedLevels.Add(LxPasses[i]);

        int[] passed = passedLevels.Distinct().ToArray();

        //Array.Sort(passed);

        //passedLevels.Distinct().ToList();

        if (passed.Length != totalLevels)
            return "Oh, my keyboard!";
        else
            return "I become the guy.";
    }

    static void Main()
    {
        int totalLevels = int.Parse(Console.ReadLine());

        int[] Xpasses = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int[] LxPasses = Array.ConvertAll(ReadLine().Split(), int.Parse);

        Problem_469A solution = new Problem_469A();

        Write(solution.Solve(totalLevels, Xpasses, LxPasses));
    }
}