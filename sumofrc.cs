using System;
class sumofrowandcolumns
{
    static void Main()
    {
        Console.WriteLine("Enter rows and colm value :");
        Console.Write("R : ");
        int r=Convert.ToInt32(Console.ReadLine());
        Console.Write("C : ");
        int c=Convert.ToInt32(Console.ReadLine());
        int [,] a=new int[r,c];
        Console.WriteLine("Enter values in the 2D array:");
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                a[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
       for(int i=0;i<r;i++)
       {
           for(int j=0;j<c;j++)
           {
               Console.Write(a[i,j]+" ");
           }
           Console.WriteLine();
       }
        int sr=0,sc=0;
        for(int i=0;i<r;i++)
        {
            sr=0;sc=0;
            for(int j=0;j<c;j++)
            {
                sr=sr+a[i,j];
                sc=sc+a[j,i];
            }
            Console.WriteLine(sr+" "+sc);
        }
    }
}