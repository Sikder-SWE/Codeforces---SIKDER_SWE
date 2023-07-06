using static System.Console;

class Problem_617A
{
    static void Main(string[] args)
    {
        int x = int.Parse(ReadLine());
        if (x % 5 == 0)
            WriteLine(x / 5);
        else
            WriteLine((x / 5) + 1);
    }
}