using System;
class pall
{
	static void Main()
	{
		int n,s=0,t,r;
		Console.WriteLine("Enter a number:");
		n=int.Parse(Console.ReadLine());
		t=n;
		while(n!=0)
		{
			r=n%10;
			s=(s*10)+r;
			n=n/10;
		}
		if(t==s)
		Console.WriteLine("Pallindrome");
		else
		Console.WriteLine("Not Pallindrome");
	}
}