using System;
using static System.Console;

class Problem1822A
{
    static void Main()
    {
        int Test_case = int.Parse(ReadLine());
        //Write(Test_case);

        while(Test_case > 0) 
        {
            Test_case--;
            var nt = Array.ConvertAll(ReadLine().Split(), int.Parse);

            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);

            int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse);
            //Console.WriteLine(nt[0]);
            Array.Sort(a);
            int small = a[0];

            if (small <= nt[1])
            {
                foreach (int value in a)
                {
                    if (value <= small)
                    {
                        WriteLine(a.Length/2 + 1);
                        break;
                    }
                    else
                        continue;
                }
            }
            else
                WriteLine("-1");
        }
    }
}