using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> _allTasks = new List<Task>();

    public void AddTask(Task task)
    {
        _allTasks.Add(task);
    }

    public void RemoveTask(int id)
    {
        int indexToRemove = -1;

        for (int i = 0; i < _allTasks.Count; i++)
        {
            if (_allTasks[i].GetId() == id)
            {
                indexToRemove = i;
                break;
            }
        }

        if (indexToRemove != -1)
        {
            _allTasks.RemoveAt(indexToRemove);
        }
    }

    public void MarkTaskComplete(int id)
    {
        foreach (Task t in _allTasks)
        {
            if (t.GetId() == id)
            {
                t.MarkComplete();
                return;
            }
        }
    }

    public List<Task> GetAllTasks()
    {
        return _allTasks;
    }
}