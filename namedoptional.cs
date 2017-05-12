using System;
class Employee
{
	public static void Show(int roll,string name)
	{
		Console.WriteLine(roll+" "+name);
	}
	public static void Main()
	{
		Show(101,"Amit");//older way
		Show(name:"Kaushik",roll:478);//new way
	}
}