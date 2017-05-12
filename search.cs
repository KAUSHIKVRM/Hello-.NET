using System;
class search
{
    static void Main()
    {
        int []a={4,3,6,1,8};
        Console.Write("Enter an element to be searched : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int f=0;
        foreach(int x in a)
        {
            if(n==x)
            {
                f=1;
                break;
            }
        }
        if(f==1)
        Console.Write("Element found");
        else
        Console.Write("Not Found");
    }
}