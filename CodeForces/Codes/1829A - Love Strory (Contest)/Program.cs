using System;
using static System.Console;

public class Problem_Contest1829A
{
    public static void Main()
    {

        string fixedWord = "codeforces";
        int testCase = int.Parse(ReadLine());
        while (testCase > 0)
        {
            testCase--;
            string word = ReadLine();
            int count = 0;

            for (int i = 0; i < fixedWord.Length; i++)
            {
                if (fixedWord[i] != word[i])
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
