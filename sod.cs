using System;
class SOD
{
	static void Main()
	{
		int n,s=0,i;
		Console.WriteLine("Enter a four digit number");
		n=int.Parse(Console.ReadLine());
		for(i=0;i<4;i++)
		{
			s=s+n%10;
			n=n/10;
		}
		Console.WriteLine("Sum of digits is "+s);
	}
}