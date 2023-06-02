using System;
using static System.Console;

class Problem_344A
{
    public int Solution(int TestCase, string[] Arrangement)
    {

        int Group = 1;


        for (int i = 0; i < TestCase - 1; i++)
        {
            bool connection = false;
            if (Arrangement[i] == Arrangement[i + 1])
                connection = true;

            if (connection)
                continue;
            else
                Group++;
        }
        return Group;

        /*foreach(string indexValue in Arrangement)
        Write($" {indexValue}");*/
    }

    static void Main()
    {
        int TestCase = int.Parse(ReadLine());
        string[] Poles = new string[TestCase];

        for (int i = 0; i < TestCase; i++)
            Poles[i] = ReadLine();

        Problem_344A code = new Problem_344A();

        //code.Solution(TestCase, Poles);


        //int Answer = code.Solution(TestCase, Poles);
        Write($"{code.Solution(TestCase, Poles)}");


    }
}