using System;
class pat1
{
	static void Main()
	{
		int n,i,j;
		Console.WriteLine("Enter a number:");
		n=int.Parse(Console.ReadLine());
		for(i=0;i<n;i++)
		{
			for(j=0;j<=i;j++)
			{
				Console.Write("* ");
			}
			Console.WriteLine();
		}
	}
}