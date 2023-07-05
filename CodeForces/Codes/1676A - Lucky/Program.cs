using static System.Console;

class Problem_1676A
{
    static void Main()
    {

        int t = int.Parse(ReadLine());

        while (t-- > 0)
        {
            var str = ReadLine();
            var n1 = int.Parse(str.Substring(0, 3));
            var n2 = int.Parse(str.Substring(3, 3));

            int s1 = 0;
            int s2 = 0;

            for (int i = 0; i < str.Length / 2; i++)
            {
                s1 += n1 % 10;
                n1 /= 10;

                s2 += n2 % 10;
                n2 /= 10;
            }

            if (s1 == s2)
                WriteLine("YES");
            else
                WriteLine("NO");
        }

    }
}