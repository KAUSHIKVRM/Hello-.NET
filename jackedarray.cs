using System;
class jackedArray
{
    static void Main()
    {
        int [][] arr=new int[4][];
        arr[0]=new int[4]{1,2,3,4};//0th row will take 4 columns
        arr[1]=new int[2]{5,6};//1st row will take 2 columms and so on
        arr[2]=new int[3]{7,8,9};
        arr[3]=new int[1]{10};
        for(int i=0;i<4;i++)
        {
            for(int j=0;j<arr[i].Length;j++)
            {
                Console.Write(arr[i][j]+" ");
            }
            Console.WriteLine();
        }
        //using foreach
        foreach(int[] x in arr)//it returns the addresss of first row
        {
            foreach(int n in x)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
        }
    }
}