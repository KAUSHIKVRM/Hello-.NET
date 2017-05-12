using System;
class prime
{
	static void Main()
	{
		int n,i,c=0;
		Console.WriteLine("Enter a number:");
		n=int.Parse(Console.ReadLine());
		for(i=2;i<=n/2;i++)
		{
			if(n%i==0)
			c++;
		}
		if(c==0)
		Console.WriteLine("Prime");
		else
		Console.WriteLine("Not Prime");
	}
}