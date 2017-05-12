using System;
class freq
{
    static void Main()
    {
        Console.WriteLine("Enter the number :");
        int n=Convert.ToInt32(Console.ReadLine());
        int []a=new int[10];
        for(int i=0;i<10;i++)
        a[i]=0;
        while(n!=0)
        {
            a[n%10]+=1;
            n=n/10;
        }
        for(int i=0;i<10;i++)
        {
            if(a[i]!=0)
            Console.WriteLine(i+" "+a[i]);
        }
    }
}