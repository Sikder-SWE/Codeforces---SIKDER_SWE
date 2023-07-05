using System;

namespace Gaber
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string backup = "", song = "";
            char[] chars = { 'W', 'U', 'B' };
            int current = 0;

            words = words.Replace("WUB", " ");
            words = words.Trim();

            while (words.Contains("  "))
            {
                words = words.Replace("  ", " ");
            }

            Console.Write(words);
        }
    }
}