using System;
using static System.Console;

class Problem_337A
{
     static void Main()
    {
       int student = int.Parse(ReadLine().Split(' ')[0]);

int[] puzzles = ReadLine().Split(' ').Select(int.Parse).ToArray();

Array.Sort(puzzles);
int index = 0;
int min = puzzles[student-1] - puzzles[0];
for(int i = 1; i <= puzzles.Length-student; i++)
{
    if (puzzles[i + student - 1] - puzzles[i] <= min)
    {
        min = puzzles[i + student - 1] - puzzles[i];
        index = i;
    }
}
WriteLine(puzzles[index+student-1] - puzzles[index]);
    }
}