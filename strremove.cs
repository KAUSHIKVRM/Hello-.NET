using System;
class strrem
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence :");
        string str=Console.ReadLine();
        Console.WriteLine("Enter the character to be replaced :");
        string ch=Console.ReadLine();
        Console.WriteLine("Enter the new character :");
        string ne=Console.ReadLine();
        str=str.Replace(ch,ne);
        Console.WriteLine("New string is :"+str);
    }
}