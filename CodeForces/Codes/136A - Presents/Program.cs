using static System.Console;

class Problem_136A
{
    static void Main()
    {
        int n = Convert.ToInt32(ReadLine());
        int[] q = new int[n];

        string nums = ReadLine();
        string[] num = nums.Split(" ");
        int[] p = Array.ConvertAll(num, Convert.ToInt32);

        for (int i = 1; i <= n; i++)
        {
            q[p[i - 1] - 1] = i;
        }

        WriteLine(String.Join(" ", q));
    }
}