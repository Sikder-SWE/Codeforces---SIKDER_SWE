
// Problem link : https://codeforces.com/gym/104339/problem/A
using System;
using static System.Console;

string[] kings = { "Barley", "Hops", "Malt"};

int[] Values = Array.ConvertAll(ReadLine().Split(), int.Parse);

int[] Warriors = new int[3];

for(int i=0; i<3; i++)
{
    Warriors[i] = Values[i]*Values[i+3];
}

for (int i = 0; i < kings.Length;)
{
    if (Warriors[i] == Warriors.Max())
    {
        Write($"{kings[i]} ");
        i++;
    }
    else
    {
        i++;
        continue;
    }

 }
