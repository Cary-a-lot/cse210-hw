using System;

public class OneTimeTask : Task
{
    private DateTime _dueDate;

    public OneTimeTask(int id, string title, string description, DateTime dueDate)
        : base(id, title, description)
    {
        _dueDate = dueDate;
    }

    public override string GetStatus()
    {
        return IsCompleted()
            ? "[X] Done"
            : "[ ] Due: " + _dueDate.ToShortDateString();
    }
}