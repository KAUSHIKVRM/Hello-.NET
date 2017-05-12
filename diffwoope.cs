using System;
class Diffwoopr
{
	static void Main()
	{
		int a,b,b1,d,c,r,t,c1;
		System.Console.WriteLine("Enter values of A and B :");
		System.Console.WriteLine("A : ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("B : ");
		b=int.Parse(System.Console.ReadLine());
		///*
		t=~b;
		r=t^1;
		c1=t&1;
		c1=c1<<1;
		r=r^c1;
		System.Console.WriteLine(r);
		d=a^r;
		c=a&r;
		c=c<<1;
		d=d^c;
		//*/
		/*
		b1=(~b)+1;
		d=a^b1;
		c=a&b1;
		c=c<<1;
		d=d^c;
		*/
		System.Console.WriteLine("Difference of "+a+" and "+b+" is "+d);
	}
}