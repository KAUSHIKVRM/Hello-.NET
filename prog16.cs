using System;
class prog16
{
    static bool prime(int n)
    {
        int c=0,i;
        for(i=2;i<=n/2;i++)
        {
            if(n%i==0)
            {
                c++;
            }
        }
        if(c==0)
        return true;
        else
        return false;
    }
    static bool handsome(int n)
    {
        int u,t,h;
        u=n%10;
        n=n/10;
        t=n%10;
        n=n/10;
        h=n%10;
        if((h+t)==u)
        return true;
        else
        return false;
    }
    static void Main()
    {
        for(int i=100;i<=150;i++)
        {
            if(prime(i) && handsome(i))
            {
                break;
                //continue;
            }
            Console.Write(i+" ");
        }
    }
}