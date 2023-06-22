using static System.Console;

class Problem_318A
{
    static void Main()
    {
        long[] input = Array.ConvertAll(ReadLine().Split(), long.Parse);

        long middle = (input[0] + 1) /2;

        if (input[1]>middle)
        {
            Write(2 * (input[1] - middle));
        }
        else
        {
            Write((2 * input[1]) -1);
        }
    }
 }