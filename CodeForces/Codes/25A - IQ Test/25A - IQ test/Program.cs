using static System.Console;

class Problem_25A
{
    static void Main(string[] args)
    {
        int n = int.Parse(ReadLine());
string[] numbers = ReadLine().Split(' ');
int even = 0;
int odd = 0;
int EvenPosition = 1;
int OddPosition = 0;
for (int i = 0; i < n; i++)
{
    if (int.Parse(numbers[i]) % 2 == 0)
    {
        even++;
        EvenPosition = i + 1;
    }
    else
    {
        odd++;
        OddPosition = i + 1;
    }
}
if(odd == 1)
{
    Write(OddPosition);
}
else if (even == 1)
{
    WriteLine(EvenPosition);
}

    }
}