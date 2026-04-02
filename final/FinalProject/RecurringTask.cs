using System;

public class RecurringTask : Task
{
    private string _frequency;

    public RecurringTask(int id, string title, string description, string frequency)
        : base(id, title, description)
    {
        _frequency = frequency;
    }

    public override string GetStatus()
    {
        return IsCompleted()
            ? "[X] Done"
            : "[ ] Frequency: " + _frequency;
    }
}