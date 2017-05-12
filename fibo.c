using System;
class fibo
{
	static void Main()
	{
		int n,i,a=0,b=1,c;
		Console.WriteLine("Enter a number:");
		n=int.Parse(Console.ReadLine());
		Console.Write(a+" "+b+" ");
		for(i=0;i<n-2;i++)
		{
			c=a+b;
			Console.Write(c+" ");
			a=b;
			b=c;
		}
	}
}