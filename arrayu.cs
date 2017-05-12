using System;
class arr
{
    static void Main()
    {
        int []a=new int[10];
        int []b=new int[10];
        Console.WriteLine("Enter 10 elements in first array :");
        for(int i=0;i<10;i++)
        a[i]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 10 elements in second array :");
        for(int i=0;i<10;i++)
        b[i]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition");
        for(int i=0;i<10;i++)
        Console.Write(a[i]+b[i]+" ");
        Console.WriteLine("\nSubtraction");
        for(int i=0;i<10;i++)
        Console.Write(a[i]-b[i]+" ");
        Console.WriteLine("\nMultiplication");
        for(int i=0;i<10;i++)
        Console.Write(a[i]*b[i]+" ");
        Console.WriteLine("\nDivision");
        for(int i=0;i<10;i++)
        Console.Write(a[i]/Convert.ToDouble(b[i])+" ");
    }
}