using System;
class Employee
{
	public static void Show(out int a)
	{
		a=10;
		Console.Write(a);
	}
	public static void Main()
	{
		int x;
		Show(out x);
		Console.Write(x);
	}
}