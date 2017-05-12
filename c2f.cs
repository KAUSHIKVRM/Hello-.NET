using System;
class c2f
{
	static void Main()
	{
		double f,c;
		System.Console.WriteLine("Enter the temperature value in Celsius :");
		c=double.Parse(System.Console.ReadLine());
		f=(c*1.8)+32;
		System.Console.WriteLine("Corresponding Fahrenheit value is "+f);
	}
}