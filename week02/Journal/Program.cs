using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");
        
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();


                    Console.Write("Make this entry private? (yes/no): ");
                    string privacyInput = Console.ReadLine().ToLower();
                    bool isPrivate = privacyInput == "yes" || privacyInput == "y";
                    string password = "";
    }
}