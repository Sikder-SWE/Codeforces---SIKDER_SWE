using static System.Console;

class Problem_1742A
{
    public static void Main()
    {
        var length = int.Parse(ReadLine()!);
for (int i = 0; i != length; i++)
{
    var number = ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    //Console.WriteLine(number);
    if (number[1] + number[2] == number[0])
        WriteLine("YES");

    else if (number[2] + number[0] == number[1])
        WriteLine("YES");

    else if (number[0] + number[1] == number[2])
        WriteLine("YES");
    else
        WriteLine("NO");
}

    }
}