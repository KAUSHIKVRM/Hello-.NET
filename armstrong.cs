using System;
class Arm
{
	static void Main()
	{
		int n,r,t,s=0,c=0,i,x=1;
		System.Console.WriteLine("Enter a number:");
		n=int.Parse(System.Console.ReadLine());
		t=n;
		while(t!=0)
		{
			c++;
			t=t/10;
		}
		t=n;
		while(n!=0)
		{
			x=1;
			r=n%10;
			for(i=0;i<c;i++)
			x=r*x;
			s=s+x;
			n=n/10;
		}
		if(t==s)
		System.Console.WriteLine("Armstrong");
		else
		System.Console.WriteLine("Not ssArmstrong");
	}
}