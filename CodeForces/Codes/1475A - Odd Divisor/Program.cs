using System;
using static System.Console;

    class Problem_1475A
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            int x= Convert.ToInt32(input);
            for (int i = 0; i < x; i++)
            {
                long y = Convert.ToInt64(ReadLine());
                while (y % 2 == 0)
                {
                    y = y / 2;
                }
                if (y == 1)
                {
                    WriteLine("NO");
                }
                else
                {
                    WriteLine("YES");
                }
            }           
        }
    }
