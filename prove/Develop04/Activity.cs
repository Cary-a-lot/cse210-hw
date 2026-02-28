using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        StartActivity();
        PerformActivity();
        EndActivity();
    }