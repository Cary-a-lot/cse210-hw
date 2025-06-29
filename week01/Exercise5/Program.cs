using System;

class Program
{
    // fun 1 DisplayWelcome
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    //fun 2 prompt username
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    //function 3 user number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    //fun 4 square number
      static int SquareNumber(int number)
    {
        return number * number;
    }
}