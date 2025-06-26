using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Grade did you get?");
        Console.Write("Please input a number without the use of symbols" );
        string number = Console.ReadLine();
        int percent = int.Parse(number);

    }
}