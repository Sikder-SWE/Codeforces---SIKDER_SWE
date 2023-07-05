using System;

class Problem_1367A
{
    static void Main()
    {
        int t;
        t = int.Parse(Console.ReadLine());
        while (t > 0)
        {
            string s = Console.ReadLine();
            string res = "";
            res = res + s[0] + s[1];
            for (int i = 2; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                else
                {
                    res += s[i];

                }
            }
            Console.WriteLine(res);
            t--;
        }
    }
}
