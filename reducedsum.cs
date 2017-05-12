using System;
class reducedsum
{
    static int digit(int n)
    {
        int c=0;
        while(n!=0)
        {
            c++;
            n=n/10;
        }
        return c;
    }
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n= Convert.ToInt32(Console.ReadLine());
        int s=0,r;
        a:
        while(n!=0)
        {
            r=n%10;
            s=s+r;
            n=n/10;
        }
        if(digit(s)!=1)
        {
            n=s;
            s=0;
            goto a;
        }
        Console.Write("Reduced Sum is "+s);
    }
}