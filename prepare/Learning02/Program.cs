using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Developer of Deadly Traps";
        job._company = "ACME";
        job._startYear = 2020;
        job._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Upholstery Quality Manager";
        job2._company = "RedCo";
        job2._startYear = 2023;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Cary Choate";

        myResume._jobs.Add(job);
         myResume._jobs.Add(job2);

        job.Display();
    }
}
