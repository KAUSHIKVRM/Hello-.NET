using System;
class Negative
{
    static void Main()
    {
        int a,c,r,t;
        System.Console.WriteLine("Enter a value :");
        System.Console.WriteLine("A : ");
        a=int.Parse(System.Console.ReadLine());
        t=~a;
        r=t^1;
        c=t&1;
        c=c<<1;
        r=r^c;
        System.Console.WriteLine("Negative of "+a+" is "+r);
    }
}