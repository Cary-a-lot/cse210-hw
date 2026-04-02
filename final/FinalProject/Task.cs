using System;

public abstract class Task
{
    private int _id;
    private string _title;
    private string _description;
    private bool _isCompleted;

    public Task(int id, string title, string description)
    {
        _id = id;
        _title = title;
        _description = description;
        _isCompleted = false;
    }

    public int GetId() => _id;
    public string GetTitle() => _title;
    public bool IsCompleted() => _isCompleted;

    public virtual void MarkComplete()
    {
        _isCompleted = true;
    }

    public abstract string GetStatus();
}