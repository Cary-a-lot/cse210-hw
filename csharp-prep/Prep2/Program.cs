using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their grade percentage, then write a series of if-elif-else 
        // statements to print out the appropriate letter grade. (At this point, you'll
        // have a separate print statement for each grade letter in the appropriate block.)
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);

        Console.WriteLine(grade);

    }
}