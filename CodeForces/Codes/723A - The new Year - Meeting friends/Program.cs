using System;
using System.Linq;

class Problem_723A
{
    public static void Main()
    {
        List<int> distance = new List<int> { };
        var data = Console.ReadLine().Split(' ');

        for (int i = 0; i < data.Length; i++)
        {
            int x = Convert.ToInt32(data[i]);
            distance.Add(x);
        }
        distance.Sort();
        Console.WriteLine((distance[2] - distance[1]) + (distance[1] - distance[0]));
    }
}
