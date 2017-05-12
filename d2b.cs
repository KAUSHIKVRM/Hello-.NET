using System;
class d2b
{
    static void Main()
    {
        Console.Write("Enter Decimal input : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int br=0,b=0,i=1;
        while(n!=0)
        {
             br=br+(n%2)*i;
             i=i*10;
             n=n/2; 
        }
     
        i=1;
        while(br!=0)
        {
            b=b+(br%10)*i;
            i=i*10;
            br=br/10;
        }
        Console.Write("Binary Output is : "+b);
    }
}