using static System.Console;

class Problem_281A
{
    static void Main(string[] args)
    {
        var x = ReadLine();
        var y = x.Substring(0, 1).ToUpper() + x.Substring(1);
        WriteLine(y);
    }
}