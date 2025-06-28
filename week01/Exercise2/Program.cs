using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Grade did you get?");
        Console.Write("Please input a number without the use of symbols" );
        string number = Console.ReadLine();
        int percent = int.Parse(number);
// Grade sorting below
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

//end of grade sording
// Grade reporting
        Console.WriteLine($"Your grade is: {letter}");

        if (percent > 69)
        {
            Console.WriteLine("Congradulations you didn't fail!");
        }
        else
        {
            Console.WriteLine("Unfortunatly you did not pass. Try again?");
        }
    }
}