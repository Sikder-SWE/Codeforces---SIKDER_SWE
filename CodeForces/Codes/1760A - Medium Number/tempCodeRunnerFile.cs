using static System.Console;

class Problem_1760A
{
    static void Main(string[] args)
    {
        var count = int.Parse(ReadLine());

for (int i = 0; i < count; i++)
{
    var numbers = ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(numbers);
    WriteLine(numbers[1]);
}
    }
}