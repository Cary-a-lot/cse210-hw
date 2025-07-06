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
                if (isPrivate)
                {
                        Console.Write("Enter a password for this entry: ");
                        password = Console.ReadLine();
                }
                    string entryDate = DateTime.Now.ToShortDateString();
    
                    journal.AddEntry(new Entry(entryDate, prompt, response, isPrivate, password));
                    break;
               

                     
                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}