//Pascal triangle using 2d array
using System;
class Pascal
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int [,] a=new int[n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            a[i,j]=0;
        }
        for(int i=0;i<n;i++)
        a[i,0]=1;
        for(int i=1;i<n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                a[i,j]=a[i-1,j]+a[i-1,j-1];
            }
        }
        Console.WriteLine("Pascal Triangle :");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=i;j++)
            {
                Console.Write(a[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}