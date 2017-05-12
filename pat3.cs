using System;
class pat3
{
    static void Main()
    {
        int n,i,j;
        Console.Write("Enter a number : ");
        n=Convert.ToInt32(Console.ReadLine());
        for(i=1;i<=n;i++)
        {
            for(j=1;j<=n-i+1;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}