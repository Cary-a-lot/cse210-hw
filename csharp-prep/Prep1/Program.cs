//this is a comment that i am going to push to my repositiorey becasue the 
//assignment didn't say where so im doing it here
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
        
    }
}