using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Developer";
        job._company = "ACME";
        job._startYear = 2020;
        job._endYear = 2023;

        job.Display();
    }
}
