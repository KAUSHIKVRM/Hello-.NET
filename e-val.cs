using System;
class evalue
{
    static double fact(int n)
    {
        int i,f=1;
        for(i=1;i<=n;i++)
        f=f*i;
        return f;
    }
    static void Main()
    {
        int i;
        double ans=0.0;
        for(i=1;i<=10;i++)
        {
            ans=ans+(1/fact(i));
        }
        Console.Write(ans);
    }
}