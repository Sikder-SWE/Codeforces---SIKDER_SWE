using System;
using static System.Console;

class Problem_431A
{
    static void Main()
    {
        string[] s = ReadLine().Split(' ');
        int[]x = new int[4];
        for (int i = 0; i < 4; i++) x[i] = int.Parse(s[i]);
        string s2 = ReadLine();
        int count = 0;
        for (int i = 0; i < s2.Length; i++)
        {
            switch (s2[i])
            {
                case '1':
                    count +=x[0];
                    break;
                case '2':
                    count += x[1];
                    break;
                case '3':
                    count += x[2];
                    break;
                case '4':
                    count += x[3];
                    break;
                default:
                    break;
            }
        }
        WriteLine(count);        
    }
}

