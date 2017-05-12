using System;
class f2c
{
	static void Main()
	{
		double f,c;
		System.Console.WriteLine("Enter the temperature value in Fahrenheit :");
		f=double.Parse(System.Console.ReadLine());
		c=(f-32)*5/9;
		System.Console.WriteLine("Corresponding Fahrenheit value is "+c);
	}
}