using System;

public class Program
{
    public static void Main()
    {
        StorageManager storage = new StorageManager();
        User user = storage.LoadData();

        UIManager ui = new UIManager();
        TaskManager taskManager = new TaskManager();
        ReminderService reminder = new ReminderService();

        bool running = true;
        int nextId = 1;

        while (running)
        {
            ui.DisplayMenu();
            string choice = ui.GetUserInput();

            if (choice == "1")
            {
                ui.ShowTasks(taskManager.GetAllTasks());
            }
            else if (choice == "2")
            {
                ui.ShowHabits(user.GetHabits());
            }
            else if (choice == "3")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("1 = One-time, 2 = Recurring: ");
                string type = Console.ReadLine();

                if (type == "1")
                {
                    DateTime due = DateTime.Now.AddDays(1);
                    taskManager.AddTask(new OneTimeTask(nextId++, title, desc, due));
                }
                else
                {
                    Console.Write("Frequency: ");
                    string freq = Console.ReadLine();
                    taskManager.AddTask(new RecurringTask(nextId++, title, desc, freq));
                }
            }
            else if (choice == "4")
            {
                Console.Write("Habit name: ");
                string name = Console.ReadLine();
                user.AddHabit(new Habit(name));
            }
            else if (choice == "5")
            {
                Console.Write("Task ID: ");
                int id = int.Parse(Console.ReadLine());
                taskManager.MarkTaskComplete(id);
            }
            else if (choice == "6")
            {
                foreach (Habit h in user.GetHabits())
                {
                    h.MarkComplete();
                }
            }
            else if (choice == "7")
            {
                storage.SaveData(user);
                running = false;
            }

            reminder.CheckDueTasks(taskManager.GetAllTasks());
        }
    }
}