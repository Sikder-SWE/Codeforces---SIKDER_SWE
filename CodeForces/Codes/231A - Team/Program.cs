using static System.Console;

class Problem_231A
{
    static void Main()
    {
        int totalAssessment = 0;

        int numOfTasks = int.Parse(ReadLine());
        for (int i = 0; i < numOfTasks; i++)
        {
            string? tasks = ReadLine();
            if (tasks.Split('1').Length - 1 >= 2)
                totalAssessment++;

        }

        WriteLine(totalAssessment);
    }
}