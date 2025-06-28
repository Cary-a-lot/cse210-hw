using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // numberlist step 1
        List<int> numbers = new List<int>();

        int numberinput;
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            numberinput = int.Parse(Console.ReadLine());

            if (numberinput != 0)
            {
                numbers.Add(numberinput);
            }
        } while (numberinput != 0);

        //now for step 2 
          int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
    }
}