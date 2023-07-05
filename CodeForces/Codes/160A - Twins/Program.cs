using static System.Console;

class Problem_160A
{
    static void Main()
    {
        int tatal = int.Parse(ReadLine());
        int[] coins = ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(coins);
        Array.Reverse(coins);
        int summation = 0, maxCoin = 0, MaxV = 0;
        for (int i = 0; i < tatal; i++)
        {
            summation += coins[i];
        }
        for (int i = 0; i < tatal; i++)
        {
            if ((summation / 2) >= MaxV)
            {
                MaxV += coins[i];
                maxCoin++;
            }
            else
            {
                break;
            }
        }
        WriteLine(maxCoin);
    }
}