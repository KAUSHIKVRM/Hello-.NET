using System;
class Arm5
{
	static void Main()
	{
		int r,t,s=0,c=0,i,x=1,j,f=0;
		for(i=100;i<1000;i++)
		{
			t=i; c=0;
			while(t!=0)
			{
				c++;
				t=t/10;
			}
			t=i;
			s=0;
			while(t!=0)
			{
				x=1;
				r=t%10;
				for(j=0;j<c;j++)
				x=r*x;
				s=s+x;
				t=t/10;
			}
			if(i==s)
			{
				System.Console.WriteLine(i);
				f++;
				if(f==5)
				break;
			}
		}
	}
}