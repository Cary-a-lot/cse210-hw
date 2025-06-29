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
    //fun 5 results
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
    //all back together with main 
      static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);
    }
}