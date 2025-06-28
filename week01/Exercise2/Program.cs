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
        string Grade = "";

        if (percent >= 90)
        {
            Grade = "A";
        }
        else if (percent >= 80)
        {
            Grade = "B";
        }
        else if (percent >= 70)
        {
            Grade = "C";
        }
        else if (percent >= 60)
        {
            Grade = "D";
        }
        else if (percent <= 59)
        {
            Grade = "F";
        }
//end of grade sording

    }
}