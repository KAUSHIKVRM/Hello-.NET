using System;
class eog
{
    static void Main()
    {
        Console.WriteLine("Enter the number :");
        int n=Convert.ToInt32(Console.ReadLine());
        if(n%2==0)
        goto a;
        else
        goto b;
        b:
            Console.WriteLine("Odd no.");
            goto c;
        a:
        Console.WriteLine("Even no.");
        c:
        ;
    }
}