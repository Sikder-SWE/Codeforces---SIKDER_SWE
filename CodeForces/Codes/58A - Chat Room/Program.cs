using static System.Console;

class Problem58A
{
    public static void Main(string[] args)
    {
        string MainWord = "hello";

        string Word = ReadLine();
        int count = 0;
        for (int i = 0;i<Word.Length;i++)
        {
            if (MainWord[count] == Word[i])
                count++;

            if (count == 5) break;
        }
        Write(count==5?"YES":"NO");
    }
}