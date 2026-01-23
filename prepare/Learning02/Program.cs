using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Job job = new Job();
        job._jobTitle = "Developer";
        job._company = "ACME";
        job._startYear = 2020;
        job._endYear = 2023;
        job.Display();
    }

    public class Job
    {
        // Member variables
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        // Method to display job details
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}