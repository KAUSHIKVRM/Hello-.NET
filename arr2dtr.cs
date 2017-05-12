using System;
class search
{
    static void Main()
    {
        int [,]a={{4,3,6},{1,8,3},{6,4,8}};
        Console.WriteLine("Normal Array :");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(a[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Transposed Array :");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(a[j,i]+" ");
            }
            Console.WriteLine();
        }
    }
}