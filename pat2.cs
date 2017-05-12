using System;
class pat2
{
	static void Main()
	{
		int n,i,j=65;
		
		Console.WriteLine("Enter a number:");
		n=int.Parse(Console.ReadLine());
		for(i=65;i<65+n;i++)
		{
			for(j=65;j<=i;j++)
			{
				
				Console.Write(Convert.ToChar(j)+" ");
			}
			Console.WriteLine();
		}
	}
}