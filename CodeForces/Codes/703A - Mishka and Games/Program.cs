using static System.Console;

class Problem_703A
{
    public static void Main(string[] args)
    {
        int x;
var variable = ReadLine();
x=int.Parse(variable);
int Mishka = 0, Player2 = 0;
for (int i = 0; i < x; i++)
{
    var w = ReadLine();
    var e = w.Split(" ");
    if (int.Parse(e[0]) > int.Parse(e[1]))
        Mishka++;
    else if (int.Parse(e[0]) < int.Parse(e[1]))
        Player2++;
}

if (Mishka > Player2)
    WriteLine("Mishka");
else if (Mishka == Player2)
    WriteLine("Friendship is magic!^^");
else if (Mishka < Player2)
    WriteLine("Chris");

    }
}