using System;
class Arrayprop
{
       static void Main()
         {
            int[] arr={19,3,45,2,76,34,87,90,1,-9,-6,-8,-2,-8};
            //Array.Sort(arr);
            //Array.Clear(arr,1,3);
            int value =Array.IndexOf(arr,3);
            for(int i=0;i<arr.Length;i++)
            Console.Write(arr[i]+" ");
             Console.Write("\n"+value);
         }
}