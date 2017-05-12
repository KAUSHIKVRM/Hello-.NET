using System;
class handsome
{
    static void Main()
    {
        int i,u,t,h,n;
        for(i=100;i<1000;i++)
        {
            n=i;
            u=n%10;
            n=n/10;
            t=n%10;
            n=n/10;
            h=n;
            if((h+t)==u)
            Console.Write(i+" ");
        }
    }
}