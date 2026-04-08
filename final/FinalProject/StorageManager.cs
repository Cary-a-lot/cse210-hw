using System;

public class StorageManager
{
    public void SaveData(User user)
    {
        Console.WriteLine("Data saved (mock).");
    }

    public User LoadData()
    {
        Console.WriteLine("Loading data (mock).");
        return new User("DefaultUser");
    }
}