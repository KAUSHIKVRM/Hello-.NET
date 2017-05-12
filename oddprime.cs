using System;
class Oddprime
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
        int []a=new int[5];
        int k=0;
        for(int i=3;;i=i+2)
        {
            if(prime(i))
            a[k++]=i;
            if(k==5)
            break;
        } 
        for(int i=0;i<k;i++)
        Console.Write(a[i]+" ");
    }
}