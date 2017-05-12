using System;
class Sortmerge
{
    static void Main()
    {
        Console.WriteLine("Enter the Size of 1st array");    
        int n1=Convert.ToInt32(Console.ReadLine());
        int []a1=new int[n1];
        Console.WriteLine("Enter the elements of 1st array");
        for(int i=0;i<n1;i++)
        a1[i]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Size of 2nd array");    
        int n2=Convert.ToInt32(Console.ReadLine());
        int []a2=new int[n2];
        Console.WriteLine("Enter the elements of 2nd array");
        for(int i=0;i<n2;i++)
        a2[i]=Convert.ToInt32(Console.ReadLine());
        Array.Sort(a1);
        Console.WriteLine("Sorted 1st array");
        for(int i=0;i<n1;i++)
        Console.Write(a1[i]+" ");
        Array.Sort(a2);
        Console.WriteLine("Sorted 2nd array");
        for(int i=0;i<n2;i++)
        Console.Write(a2[i]+" ");
        int []a3=new int[n1+n2];
        int k=0;
        for(int i=0;i<n1;i++)
        a3[k++]=a1[i];
        for(int i=0;i<n2;i++)
        a3[k++]=a2[i];
        Array.Sort(a3);
        Console.WriteLine("Sorted Merge array");
        for(int i=0;i<k;i++)
        Console.Write(a3[i]+" ");
    }
}
