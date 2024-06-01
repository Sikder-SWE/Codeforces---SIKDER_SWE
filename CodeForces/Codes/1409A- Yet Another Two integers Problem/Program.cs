using static System.Console;

int testCase = int.Parse(ReadLine());

while (testCase > 0)
{
    var ab = Array.ConvertAll(ReadLine().Split(), int.Parse);
    int difference = Math.Abs(ab[0] - ab[1]);
    Console.WriteLine(difference/10+(difference%10>0?1:0));
    testCase--;
}