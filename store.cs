//Store Application
using System;
class Store
{
    static void Main()
    {
        int ch,k=0;
        int [] billno=new int[100];
        string [] name=new string[100];
        int [] qty=new int[100];
        double [] price=new double[100];
        double totbill=0.0;
        Console.WriteLine("Select the option:");
        do
        {
            Console.Write("Enter Bill number : ");
            billno[k]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter item name : ");
            name[k]=Console.ReadLine();
            Console.Write("Enter quantity : ");
            qty[k]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price per unit : ");
            price[k]=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Want to add more items press 1 else press any key!!!");
            ch=Convert.ToInt32(Console.ReadLine());
            k++;
        } while (ch==1);
        Console.WriteLine("B_No. Name  Qty price per unit");
        for(int i=0;i<k;i++)
        {
            Console.WriteLine(billno[i]+"  "+name[i]+"   "+qty[i]+"  "+price[i]);
            totbill=totbill+(qty[i]*price[i]);
        }
        Console.Write("Total bill is "+totbill);
    }
}