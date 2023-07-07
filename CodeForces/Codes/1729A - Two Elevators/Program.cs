using static System.Console;

class Problem_1729A
{
    public static void Main(string[] args)
    {
      
string tcase =ReadLine();
int t =int.Parse(tcase);
for (int i = 0; i < t; i++)
{
    string input = ReadLine();
    string[] output =input.Split(' ');
    int a = int.Parse(output[0]);
    int b = int.Parse(output[1]);
    int c = int.Parse(output[2]);

    int Val=Math.Abs(1-a), Val2= Math.Abs(b-c)+ Math.Abs(1-c);
    if (Val == Val2) { WriteLine("3"); }
    else if (Val > Val2) { WriteLine("2"); }
    else if (Val < Val2) { WriteLine("1"); }

}

    }
}