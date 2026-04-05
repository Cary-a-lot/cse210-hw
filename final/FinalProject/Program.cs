using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        TaskManager manager = new TaskManager();
        bool running = true;
        int nextId = 1;

        Console.WriteLine("Welcome to Task Manager!");

        while (running)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                List<Task> tasks = manager.GetAllTasks();

                foreach (Task t in tasks)
                {
                    Console.WriteLine($"{t.GetId()}. {t.GetTitle()} - {t.GetStatus()}");
                }
            }
            else if (input == "2")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.WriteLine("Type: 1 = One-time, 2 = Recurring");
                string type = Console.ReadLine();

                if (type == "1")
                {
                    Console.Write("Due date (yyyy-mm-dd): ");
                    DateTime due = DateTime.Parse(Console.ReadLine());

                    manager.AddTask(new OneTimeTask(nextId++, title, desc, due));
                }
                else
                {
                    Console.Write("Frequency: ");
                    string freq = Console.ReadLine();

                    manager.AddTask(new RecurringTask(nextId++, title, desc, freq));
                }
            }
            else if (input == "3")
            {
                Console.Write("Enter task ID to complete: ");
                int id = int.Parse(Console.ReadLine());

                manager.MarkTaskComplete(id);
            }
            else if (input == "4")
            {
                Console.Write("Enter task ID to remove: ");
                int id = int.Parse(Console.ReadLine());

                manager.RemoveTask(id);
            }
            else if (input == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}