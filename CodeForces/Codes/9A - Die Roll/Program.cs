using static System.Console;

class Problem_9A
{
    static void Main()
    {
        int[] Values = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int res = 7 - Math.Max(Values[0], Values[1]);
        switch (res)
        {
            case 2:
            case 4:
                {
                    WriteLine(res / 2 + "/3");
                    break;
                }
            case 6:
                {
                    WriteLine("1/1");
                    break;
                }
            case 3:
                {
                    WriteLine("1/2");
                    break;
                }
            case 5:
                {
                    WriteLine("5/6");
                    break;
                }
            case 1:
                {
                    WriteLine(res + "/6");
                    break;
                }
        }
    }
}