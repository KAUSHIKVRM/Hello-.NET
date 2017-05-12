using System;
class marksgreet
{
    static void Main()
    {
        Console.Write("Enter the marks to see your greeting message : ");
        int n=Convert.ToInt32(Console.ReadLine());
        if(n<50)
        Console.Write("Your grade is D");
        else if(n>=50 && n<=59)
        Console.Write("Your grade is C");
        else if(n>=60 && n<=69)
        Console.Write("Your grade is B");
        else if(n>=70 && n<=79)
        Console.Write("Your grade is A");
        else if(n>=80 && n<=89)
        Console.Write("Your grade is E");
        else
        Console.Write("Your grade is O");
    }
}