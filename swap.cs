using System;
class Swap
{
	static void Main()
	{
		int a,b;
		System.Console.WriteLine("Enter 2 Numbers which are to be swapped :");
		System.Console.WriteLine("A : ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("B : ");
		b=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Before Swapping "+a+" "+b);
		a=a+b;
		b=a-b;
		a=a-b;
		System.Console.WriteLine("After Swapping "+a+" "+b);
	}
}