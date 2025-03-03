using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job job2 = new job();
        job2._jobTitle = "Software Develoment";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        resume resume = new resume();
        resume._name = "Alisson Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.Display();
    }
}