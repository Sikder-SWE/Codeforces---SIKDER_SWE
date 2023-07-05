using static System.Console;

class Problem_268A
{
    static void Main(string[] args)
    {
        int n = int.Parse(ReadLine());
        int count = 0;

        int[,] teams = new int[n, 2];
        for (int i = 0; i < n; i++)
        {
            string[] tokens = ReadLine().Split();
            teams[i, 0] = int.Parse(tokens[0]);
            teams[i, 1] = int.Parse(tokens[1]);
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j && teams[i, 0] == teams[j, 1])
                {
                    count++;
                }
            }
        }

        WriteLine(count);
    }
}