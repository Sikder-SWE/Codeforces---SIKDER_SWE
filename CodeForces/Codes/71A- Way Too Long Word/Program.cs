//Problem link: https://codeforces.com/contest/71/problem/A

using System;

class Problem_71A
{
    static void Main()
    {
        string word;
        int test_case;
        test_case = int.Parse(Console.ReadLine());
        while (test_case != 0)
        {
            word = Console.ReadLine();
            if (word.Length > 10)
            {
                Console.WriteLine($"{word[0]}{word.Length - 2}{word[word.Length - 1]}");
            }
            else
                Console.WriteLine($"{word}");
            test_case--;
        }
    }
}