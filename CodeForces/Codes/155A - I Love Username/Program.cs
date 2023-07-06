using static System.Console;

class Problem_155A
{
    static void Main()
    {
        int n = Convert.ToInt32(ReadLine());
        string str = ReadLine();
        string[] values = str.Split(" ");
        int[] num = Array.ConvertAll(values, Convert.ToInt32);

        int[] Array1 = new int[0];
        int count = 0;

        for (int i = 0; i < n - 1; i++)
        {
            Array1 = Array1.Concat(new int[] { num[i] }).ToArray();
            if (num[i + 1] > Array1.Max()) count++;
            if (num[i + 1] < Array1.Min()) count++;
        }
        WriteLine(count);
    }
}