using System;

public class Habit
{
    private string _name;
    private int _streakCount;
    private DateTime _lastCompletedDate;

    public Habit(string name)
    {
        _name = name;
        _streakCount = 0;
    }

    public string GetName() => _name;

    public void MarkComplete()
    {
        DateTime today = DateTime.Today;

        if (_lastCompletedDate == today.AddDays(-1))
        {
            _streakCount++;
        }
        else if (_lastCompletedDate != today)
        {
            _streakCount = 1;
        }

        _lastCompletedDate = today;
    }

    public int GetStreak()
    {
        return _streakCount;
    }
}