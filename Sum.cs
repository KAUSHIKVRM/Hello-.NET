using System;
class Add
{
	static void Main()
	{
		int a,b;
		System.Console.WriteLine("Enter 2 values :");
		System.Console.WriteLine("A = ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("B = ");
		b=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Sum of "+a+" and "+b+" is "+(a+b));
	}
}