﻿using static System.Console;
class Problem_1352A
{
    static void Main(string[] args)
    {
        
        int TestCase = int.Parse(ReadLine());
        while (TestCase > 0)
        {
            int count = 0, Remainder, temp, x = 1;
            TestCase--;
            int Value = int.Parse(ReadLine());
            //WriteLine(Value);
            temp = Value;
            
            while(Value>0)
            {
                Remainder = Value % 10;
                if(Remainder > 0)
                    count++;
                Value /= 10;
                //WriteLine(Value);
            }
            WriteLine(count);

            while(temp> 0)
            {
                if(temp%10!=0)
                Write((temp % 10) * x +" ");
                x *= 10;
                temp /= 10;
            }
           WriteLine();
        }
    }
}