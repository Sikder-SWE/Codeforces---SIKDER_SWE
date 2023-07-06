using static System.Console;

class  Problem_510A
{
    static void Main(string[] args)
    {
        string s = ReadLine();
string[] values = s.Split(' ');

int N = int.Parse(values[0]);
int M = int.Parse(values[1]);

for(int i = 1; i <= N; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 1; j <= M; j++)
        {
            Write('#');
        }
        WriteLine();
    }
    else
    {
        if(i % 4 != 0)
        {
            for (int j = 1; j < M; j++)
            {
                Write('.');
            }
            Write('#');
            WriteLine();
        }
        else
        {
            Write('#');
            for (int j = 2; j <=M; j++)
            {
                Write('.');
            }
           
            WriteLine();
        }
    }   
}
    }
}