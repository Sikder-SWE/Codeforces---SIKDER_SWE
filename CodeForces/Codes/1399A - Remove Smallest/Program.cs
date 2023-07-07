using static System.Console;

class Problem_1399A
{
    static void Main(string[] args)
    {
        int t = int.Parse(ReadLine() ?? string.Empty);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(ReadLine() ?? string.Empty);
    int[] array = new int[n];
    string[] input = ReadLine()?.Split(' ') ?? new string[1];
    for (int j = 0; j < n; j++)
    {
        array[j] = int.Parse(input[j]);
    }
    Array.Sort(array);
    bool signal = true;
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j + 1] - array[j] > 1)
        {
            signal = false;
            break;
        }
    }
    WriteLine(signal ? "YES" : "NO");
}
    }
}