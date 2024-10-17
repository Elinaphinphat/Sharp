// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Insert Length: ");
        int UserInputLength = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Insert Width: ");
        int UserInputWidth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The area of this rectangle is " + (UserInputLength * UserInputWidth));
    }
}
