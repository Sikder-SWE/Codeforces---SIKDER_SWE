// Problem link : https://codeforces.com/problemset/problem/41/a

// Submission link : https://codeforces.com/contest/41/submission/205979898
using System;
using static System.Console;

string BerlandWord, BirlandWord;

BerlandWord = ReadLine();
BirlandWord= ReadLine();

string blank= null;

for(int i = BirlandWord.Length-1; i>= 0 ; i--)
{
    blank += BirlandWord[i];
}

if (blank == BerlandWord)
    Write("YES");
else
    Write("NO");