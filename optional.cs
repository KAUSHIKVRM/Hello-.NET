using System;
class Employee
{
	public static void Show(int roll,string name,string clg="Kiit")//optional argument default value
	{
		Console.WriteLine(roll+" "+name+" "+clg);
	}
	public static void Main()
	{
		Show(101,"Amit");//older way
		Show(name:"Kaushik",roll:478,clg:"IIT");//new way
	}
}