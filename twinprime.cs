//twin primes
using System;
class twinprime
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
    static void Main()
    {
        int k=0;
        int []pt=new int[200];
        for(int i=3;i<500;i=i+2)
        {
            if(prime(i))
            pt[k++]=i;
        }
        for(int i=0;i<k-1;i++)
        {
            if(pt[i+1]-pt[i]==2)
            Console.WriteLine(pt[i]+" "+pt[i+1]);
        }
    }
}