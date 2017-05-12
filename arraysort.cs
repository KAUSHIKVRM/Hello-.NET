using System;
class sort
{
    static void Main()
    {
        int []a={4,3,6,1,8};
        int i,j,t;
        for(i=1;i<=a.Length-1;i++)
        {
            for(j=0;j<a.Length-1;j++)
            {
                if(a[j]>a[j+1])
                {
                    t=a[j];
                    a[j]=a[j+1];
                    a[j+1]=t;
                }
            }
        }
        Console.Write("Sorted Array is :");
        foreach(int x in a)
        Console.Write(x+" ");
    }
}