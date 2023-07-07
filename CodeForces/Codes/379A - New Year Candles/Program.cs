using System;
using static System.Console;

 class Problem_379A
{
	public static void Main()
	{
		string Value = ReadLine();
		int[] temp = Value.Split(' ').Select(int.Parse).ToArray();
		int res = temp[0];
		int tem = 0;
		
		while(temp[0] >= temp[1]){
			tem = temp[0] % temp[1];
			temp[0] /=  temp[1];
			res += temp[0];
			temp[0] += tem;
		}
		res += tem / temp[1];
		Write(res);
	}
}