using System;
class series
{
    static double fact(int n)
    {
        int i,f=1;
        if(n==0)
        return 1;
        for(i=1;i<=n;i++)
		{
			f=f*i;
		}
        return f;
    }
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        double ans=0.0;
        for(int i=1;i<=n;i++)
        ans=ans+((i+1)/(2*fact(i-1)));
        Console.Write("Answer is "+ans);
    }
}