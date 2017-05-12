using System;
class sum
{
    static void Main()
    {
        int []a={4,3,6,1,8};
        int s=0;
        foreach(int x in a)
        {
           s=s+x;
        }
        Console.Write("Sum is "+s);
    }
}