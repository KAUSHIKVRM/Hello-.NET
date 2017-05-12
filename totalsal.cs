using System;
class totalsalary
{
    static void Main()
    {
        double sal,da,hra,ts;
        Console.Write("Enter Basic Salary : ");
        sal=Convert.ToDouble(Console.ReadLine());
        if(sal<=2000)
        {
            da=sal*0.1;
            hra=sal*0.2;
        }
        else if(sal>2000 && sal<=5000)
        {
            da=sal*0.2;
            hra=sal*0.3;
        }
        else if(sal>5000 && sal<=10000)
        {
            da=sal*0.3;
            hra=sal*0.4;
        }
        else
        {
            da=sal*0.5;
            hra=sal*0.5;
        }
        ts=sal+da+hra;
        Console.Write("Total Salary is "+ts);
    }
}