using static System.Console;

class Problem_1560A
{
    static void Main()
    {
        int[] NumbersNotDevided = new int[1800];
        int Initial = 1;
        int testCase = int.Parse(ReadLine());
        for(int i = 0; i < 1800;)
        {
            if(Initial%3!= 0 && Initial%10!=3)
            {                
                NumbersNotDevided[i] = Initial;               
                Initial++;
                i++;
                continue;
            }
            else
            {
                Initial++;
                continue;
            }
        }

        while(testCase>0)
        {
            testCase--;
            WriteLine(NumbersNotDevided[int.Parse(ReadLine())-1]);
        }
    }
}