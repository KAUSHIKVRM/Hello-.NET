using System;
using System.Collections;
class Solution 
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        decimal s=0;
        decimal rs=0;
       ArrayList a=new ArrayList();
        
        for(int i=0;i<n;i++)
             a.Add(Console.ReadLine());
        a.Reverse();
       foreach(decimal d in a)
	   {
		  s=s+rs%d;
		  rs=rs+d;
	   }
        Console.WriteLine(s);
        Console.ReadLine();
    }
}
