using static System.Console;

class Problem_1807A
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(ReadLine());

for(int i=0; i<t; i++)
{
    string[] values = ReadLine().Split(' ');

    int a = Convert.ToInt32(values[0]);
    int b = Convert.ToInt32(values[1]);
    int c = Convert.ToInt32(values[2]);

    if (a + b == c) WriteLine('+');
    else WriteLine('-');
}
    }
}