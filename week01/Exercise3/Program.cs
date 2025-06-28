using System;

using System;

class Program
{
    static void Main(string[] args)
    {
//generating for step 3 random magic number
        Random randomnumber = new Random();
        int magicnumber = randomnumber.Next(1, 101); // 1 to 100

        int guess = -1; // I kept wanting to do +3 but i dont think thatll work unless i make the range diffrent.

        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); 

            if (guess < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
    }
}
