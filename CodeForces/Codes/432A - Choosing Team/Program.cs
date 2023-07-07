using static System.Console;

class Problem_432A
{
    public static void Main(string[] args)
    {
        string[] nums = ReadLine().Split(' ');
int n = int.Parse(nums[0]);
int k = int.Parse(nums[1]);
int[] store = new int[n];
string[] inputs = ReadLine().Split(' ');
for (int i = 0; i <n; i++)
{
    store[i] = int.Parse(inputs[i]);
}
int count = 0;
for (int i = 0; i < n; i++)
{
    if (store[i] + k <= 5)
    {
        count++;
    }
}
WriteLine(count / 3);
    }
}