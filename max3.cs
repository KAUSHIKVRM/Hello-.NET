using System;
class Max3
{
	static void Main()
	{
		int a,b,c,x;
		System.Console.WriteLine("Enter 3 numbers: ");
		System.Console.Write("A : ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.Write("B : ");
		b=int.Parse(System.Console.ReadLine());
		System.Console.Write("C : ");
		c=int.Parse(System.Console.ReadLine());
		x=(a>b)?a:b;
		System.Console.Write("Maximun of "+a+", "+b+", "+"and "+c+" is "+((x>c)?x:c));
	}
}