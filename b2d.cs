using System;
class b2d
{
    static void Main()
    {
        Console.Write("Enter Binary input : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int r,s=0,p=1,c=0,i;
        while(n!=0)
        {
            p=1;
            r=n%10;
            for(i=0;i<c;i++)
            {
                p=p*2;
            }
            s=s+(p*r);
            c++;
            n=n/10;
        }
        Console.Write("Corresponding decimal is "+s);
    }
}