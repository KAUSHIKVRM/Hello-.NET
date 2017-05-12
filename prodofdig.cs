using System;
class productofdigits
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int r,p=1;
        while(n!=0)
        {
            r=n%10;
            p=p*r;
            n=n/10;
        }
        Console.Write("Product of digits of entered number is "+p);
    }
}