using System;
static class xyz
{
	static int x;
}
class Employee
{
	int x;
	static int y;
	static Employee()//Static constructor
	{
		Console.WriteLine("static constructor");
	}
	public Employee()//default constructor
	{
		x=0;
	}
	public Employee(int a)//parameterized constructor
	{
		x=a;
	}
	public static void Main()
	{
		Employee ob=new Employee();
		Console.WriteLine(ob.x);
		Employee ob1=new Employee(10);
		Console.WriteLine(ob1.x);
	}
}