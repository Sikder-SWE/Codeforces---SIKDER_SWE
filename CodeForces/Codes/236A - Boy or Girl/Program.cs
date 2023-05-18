using System;
using static System.Console;
using System.Collections.Generic;

class Program236A
{
    static void Main()
    {
        string userName;
        //string tmp;
        int distinctChar=0;
        userName = Console.ReadLine();
        HashSet<char> tmp = new HashSet<char>();
        for(int i=0; i<userName.Length; i++)
        {
            tmp.Add(userName[i]);
        }
        userName = null;
        foreach(char ch in tmp)
        userName+=ch;
        //Write(userName);

        if (userName.Length % 2 == 0)
            Write("CHAT WITH HER!");
        else
            Write("IGNORE HIM!");
    }
}