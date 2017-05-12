using System;
class pat4
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int i,j,k,l;
        for(i=1;i<=n;i++)
        {
            for(k=1;k<=n-i;k++)
            {
                Console.Write("  ");
            }
            for(j=1;j<=2*i-1;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        l=2*n-1;
        for(i=1;i<=n-1;i++)
        {
            for(j=1;j<=i;j++)
            {
                Console.Write("  ");
            }
            for(k=1;k<=l-2*i;k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}