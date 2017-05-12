using System;
class sumofrowandcolumns
{
    static void Main()
    {
        Console.WriteLine("Enter rows and colm value of matrix 1:");
        Console.Write("R1 : ");
        int r1=Convert.ToInt32(Console.ReadLine());
        Console.Write("C1 : ");
        int c1=Convert.ToInt32(Console.ReadLine());
        int [,] a1=new int[r1,c1];
        Console.WriteLine("Enter values in the 2D array:");
        for(int i=0;i<r1;i++)
        {
            for(int j=0;j<c1;j++)
            {
                a1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter rows and colm value of matrix 2:");
        Console.Write("R2 : ");
        int r2=Convert.ToInt32(Console.ReadLine());
        Console.Write("C2 : ");
        int c2=Convert.ToInt32(Console.ReadLine());
        int [,] a2=new int[r2,c2];
        Console.WriteLine("Enter values in the 2D array:");
        for(int i=0;i<r2;i++)
        {
            for(int j=0;j<c2;j++)
            {
                a2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix 1:");
       for(int i=0;i<r1;i++)
       {
           for(int j=0;j<c1;j++)
           {
               Console.Write(a1[i,j]+" ");
           }
           Console.WriteLine();
       }
       Console.WriteLine("Matrix 2:");
       for(int i=0;i<r2;i++)
       {
           for(int j=0;j<c2;j++)
           {
               Console.Write(a2[i,j]+" ");
           }
           Console.WriteLine();
       }
       if(r1==r2 && c1==c2)
       {
         Console.WriteLine("Matrix Addition is:");
         for(int i=0;i<r1;i++)
         {
             for(int j=0;j<c1;j++)
               {
                   Console.Write(a1[i,j]+a2[i,j]+" ");
               }
            Console.WriteLine();
        }
       }
       else
       {
           Console.WriteLine("Addition not possible.....");
       }
       if(c1==r2)
       {
             int[,] c = new int[r1, c2];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                     c[i,j]=0;
                     for (int k = 0; k < r2; k++)
                     {
                         c[i, j] +=  a1[i, k] * a2[k, j];
                     }
                 }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(c[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
       else
       Console.Write("Multiplication not possible.....");
    }
}