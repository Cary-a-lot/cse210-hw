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
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int x = int.Parse(magicNumber);
        int y = int.Parse(guess);
        
        if (x == y)
        {
           Console.WriteLine($"Your guess of {x} is correct!"); 
        }

        else if (x > y)
        {
            Console.WriteLine($"Your guess of {x} is too low.");
        }

        else if (x < y)
        {
            Console.WriteLine($"Your guess of {x} is too high.");
        }
        //Console.WriteLine(magicNumber);
    }
}