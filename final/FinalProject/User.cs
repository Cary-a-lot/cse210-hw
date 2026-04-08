using System.Collections.Generic;

public class User
{
    private string _username;
    private List<Task> _tasks = new List<Task>();
    private List<Habit> _habits = new List<Habit>();

    public User(string username)
    {
        _username = username;
    }

    public string GetUsername() => _username;

    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }

    public void AddHabit(Habit habit)
    {
        _habits.Add(habit);
    }

    public List<Task> GetTasks()
    {
        return _tasks;
    }

    public List<Habit> GetHabits()
    {
        return _habits;
    }
}