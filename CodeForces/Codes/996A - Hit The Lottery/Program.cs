//Submission : https://codeforces.com/contest/996/submission/209560623

using static System.Console;

class Problem_996A
{
    public int bills = 0;
    int[] denominations = { 100, 20, 10, 5, 1 };
    int Amount;
    public Problem_996A(int amount)
    {
        Amount = amount;
        //return Solution(amount);
    }
    public int Solution()
    {
       foreach(int range in denominations)
        {
            if(Amount%range == 0)
            {
                bills += Amount / range;
                return bills;
            }
            else
            {
                bills += Amount / range;
                Amount %= range;
            }
        }
        return bills;
    }
    
    static void Main()
    {
        int Amount = int.Parse(ReadLine());
        Problem_996A solve = new Problem_996A(Amount);

        Write(solve.Solution());
    }
}