using static System.Console;

class Problem_96A
{
    internal string[] SubString(string str)
    {
        string tmp = String.Empty;
        int n = 7;
        string[] temp = new string[str.Length - n + 1];
        int lastIndex = str.Length - n;
        for (int i = 0; i < lastIndex; i++)
        {
            for (int j = i; j < n; j++)
                tmp += str[j];
            temp[i] = tmp;
            tmp = String.Empty;
            n++;
        }
        return temp;
    }
    public void Solution(string str, ref int Pteam, ref int Qteam)
    {
        string[] substrings = SubString(str);
        
        foreach(var s in substrings)
        {
            if (s == "1111111") Qteam++;
            else if(s == "0000000") Pteam++;
        }
        //return "";
    }

    static void Main()
    {
        string str = ReadLine();
        Problem_96A solve = new Problem_96A();
        int Qteam = 0; int Pteam = 0;
        if (str.Length < 7) Write("NO");
        else
        {
            solve.Solution(str, ref Pteam, ref Qteam);

            Write(Pteam > 0 || Qteam > 0 ? "YES" : "NO");
        }
    }
}