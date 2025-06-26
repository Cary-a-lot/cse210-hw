using System;

class Program
{static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
// the money symbol ->$<- is important or else the sting imputs won't connect.
        Console.WriteLine($"Your name is {lastname},{firstname} {lastname}");
    }
}