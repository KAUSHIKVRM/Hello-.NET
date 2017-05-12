using System;
class evalue
{
    static double fact(int n)
    {
        int i,f=1;
        for(i=1;i<=n;i++)
        f=f*i;
        return f;
    }
    static void Main()
    {
        int x,y,z;
        double ans;
        Console.Write("Enter value of x : ");
        x=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of y : ");
        y=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of z : ");
        z=Convert.ToInt32(Console.ReadLine());
        ans=Convert.ToDouble((fact(x)+fact(y))/fact(z));
        Console.Write(ans);
    }
}