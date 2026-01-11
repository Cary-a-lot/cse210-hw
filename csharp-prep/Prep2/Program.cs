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

        if (x > 89)
        {
            Console.WriteLine("You scored above 89 thats an A! ");
        }
        else if (x > 79)
        {
            Console.WriteLine("You scored above a 79. That is a B.");
        }
        else if (x > 69)
        {
            Console.WriteLine("You managed to get above 69% That's a C...");
        }
        else if (x > 59)
        {
            Console.WriteLine("You got above the low bar of 59% That is still just a D");
        }
        else if (x < 60)
        {
            Console.WriteLine("You should have studied more, below 60% is a F");
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

        //Console.WriteLine(grade);

    }
}