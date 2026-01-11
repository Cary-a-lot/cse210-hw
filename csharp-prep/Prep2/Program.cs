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
// part 3 letter
        string letter = "";

         if (x > 89)
        {
            letter = "A";
        }
        else if (x > 79)
        {
            letter = "B";
        }
        else if (x > 69)
        {
            letter = "C";
        }
        else if (x > 59)
        {
            letter = "D";
        }
        else if (x < 60)
        {
            letter = "F";
        }
//part 2 instruction
        if (x > 69)
        {
            Console.WriteLine("You passed the test! Good job");
        }
        else if (x < 70)
        {
            Console.WriteLine("You failed the course... Better luck with study next time.");
        }

        Console.WriteLine($"Your letter grade is {letter}" );

    }
}