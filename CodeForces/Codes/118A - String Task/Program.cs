using static System.Console;

class Program
{
    static string character(ref char[] word, ref List<char> Word)
    {
        string temp = string.Empty;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        for (int i = 0; i < word.Length; i++)
        {
            bool match = false;
            for (int j = 0; j < vowels.Length; j++)
            {
                if (word[i] == vowels[j])
                {
                    match = true;
                    break;
                }
                else
                    continue;
            }
            if (match)
                continue;
            else
                temp += word[i];
            //foreach(char ch in Word) WriteLine(ch);
        }
        return temp;
    }
    static void Main()
    {
        char[] word = ReadLine().ToLower().ToArray();
        List<char> Word = new List<char>();
        string temp = character(ref word, ref Word);
        for (int i = 0; i < temp.Length; i++)
            Write("." + temp[i]);
    }
}