using System;
class Employee
{
	int emp_id;			//instance variable
	static string emp_name;		//class variable
	
	public void GetData()
	{
		Employee ob=new Employee();
		Console.WriteLine("Enter EmpId");
		ob.emp_id=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Emp name");
		emp_name=Console.ReadLine();
		DisplayData(ob);
	}
	public static void DisplayData(Employee ob)
	{
		Console.WriteLine("Employee id is "+ob.emp_id);
		Console.WriteLine("Employee name is "+emp_name);
	}
	public static void Main()
	{
		int x;			//local variable
		Employee ob=new Employee();
		ob.GetData();
		
	}
}