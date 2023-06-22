using static System.Console;

class Problem_59A
{
     public int Upper = 0, Lower = 0;
     
    public void Solution(string Word)
    {
        foreach (var k in Word)
            if ((int)k > 96) Lower++;
            else
                Upper++;
    }
    
    static void Main()
    {
        Problem_59A solve = new Problem_59A();
        string Word = ReadLine();
        solve.Solution(Word);
        Write(solve.Lower >= solve.Upper ? Word.ToLower() : Word.ToUpper());
    }
}