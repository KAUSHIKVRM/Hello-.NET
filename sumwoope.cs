using System;
class Sumwoopr
{
	static void Main()
	{
		int a,b,s,c;
		System.Console.WriteLine("Enter values of A and B :");
		System.Console.WriteLine("A : ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("B : ");
		b=int.Parse(System.Console.ReadLine());
		s=a^b;
		c=a&b;
		c=c<<1;
		s=s^c;
		System.Console.WriteLine("Sum of "+a+" and "+b+" is "+s);
	}
}