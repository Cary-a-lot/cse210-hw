using System;
using System.Collections.Generic;

public class UIManager
{
    public void DisplayMenu()
    {
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Show Tasks");
        Console.WriteLine("2. Show Habits");
        Console.WriteLine("3. Add Task");
        Console.WriteLine("4. Add Habit");
        Console.WriteLine("5. Complete Task");
        Console.WriteLine("6. Complete Habit");
        Console.WriteLine("7. Exit");
    }

    public string GetUserInput()
    {
        Console.Write("Choose: ");
        return Console.ReadLine();
    }

    public void ShowTasks(List<Task> tasks)
    {
        foreach (Task t in tasks)
        {
            Console.WriteLine($"{t.GetId()}. {t.GetTitle()} - {t.GetStatus()}");
        }
    }

    public void ShowHabits(List<Habit> habits)
    {
        foreach (Habit h in habits)
        {
            Console.WriteLine($"{h.GetName()} - Streak: {h.GetStreak()}");
        }
    }
}