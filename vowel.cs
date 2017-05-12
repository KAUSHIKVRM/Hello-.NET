using System;
class vowel
{
    static void Main()
    {
        Console.Write("Enter a character : ");
        char c=Convert.ToChar(Console.Read());
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        Console.WriteLine("You have input Vowel");
        else
        Console.WriteLine("This is not a vowel");
    }
}