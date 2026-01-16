using System;

class Program
{
    static void Main(string[] args)
    //Start by asking the user for the magic number. 
    // (In future steps, we will change this to have the computer generate 
    // a random number, but to get started, 
    // we'll just let the user decide what it is.)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();

        Console.WriteLine(magicNumber);
    }
}