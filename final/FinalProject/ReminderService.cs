using System;
using System.Collections.Generic;

public class ReminderService
{
    public void SendReminder(Task task)
    {
        if (!task.IsCompleted())
        {
            Console.WriteLine($"Reminder: {task.GetTitle()} is not complete!");
        }
    }

    public void CheckDueTasks(List<Task> tasks)
    {
        foreach (Task t in tasks)
        {
            if (!t.IsCompleted())
            {
                SendReminder(t);
            }
        }
    }
}