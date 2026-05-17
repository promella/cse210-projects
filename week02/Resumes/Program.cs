using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        job job2 = new job();
        job2._company = "Google";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;

        resume myResume = new resume();
        myResume._name = "Thando Ndlovu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}