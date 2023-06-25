using static System.Console;

class Problem_520A
{
    static void Main()
    {
        _ = ReadLine();
        char[] word = ReadLine().ToLower().Distinct().ToArray();
        WriteLine(word.Length == 26 ? "YES" : "NO");
    }
}