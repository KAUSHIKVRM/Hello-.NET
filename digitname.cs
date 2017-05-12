using System;
class printnameofdigit
{
    static void Main()
    {
        Console.Write("Enter a digit : ");
        int d=Convert.ToInt32(Console.ReadLine());
        switch(d)
        {
            case 0:Console.Write("Zero");
            break;
            case 1:Console.Write("One");
            break;
            case 2:Console.Write("Two");
            break;
            case 3:Console.Write("Three");
            break;
             case 4:Console.Write("Four");
            break;
             case 5:Console.Write("Five");
            break;
             case 6:Console.Write("Six");
            break;
             case 7:Console.Write("Seven");
            break;
             case 8:Console.Write("Eight");
            break;
             case 9:Console.Write("Nine");
            break;
            default:Console.Write("Enter a Positive and Single digit number!!!");
            break;
        }
    }
}