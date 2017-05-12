using System;
class Employee
{
	int emp_id;
	string name;
}
class xyz
{
	public void Show(int a,int b)//formal argument
	{
		a=1000;
		b=2000;
		Console.WriteLine("A = "+a+" B = "+b);
	}
	public void Show(ref int a,ref int b)//formal argument
	{
		a=1000;
		b=2000;
		Console.WriteLine("A = "+a+" B = "+b);
	}
	public static void Main()
	{
		Employee obj=new Employee();
		int x=10,y=20;
		xyz ob=new xyz();
		ob.Show(x,y);//actual argument
		Console.WriteLine("X = "+x+" Y = "+y);
		ob.Show(ref x,ref y);//actual argument
		Console.WriteLine("new X = "+x+" new Y = "+y);
	}
}