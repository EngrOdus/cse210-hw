using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        //Take the first job information
        Job job1 = new Job();
        Job job2 = new Job();

        Console.Write("What is the name of the first company you worked in? ");
        job1._companyName = Console.ReadLine();
        Console.Write("What was your role in this company? ");
        job1._jobTitle = Console.ReadLine();
        Console.Write("What was the year you started working here? ");
        job1._startYear = double.Parse(Console.ReadLine());
        Console.Write("What was the year you stopped working here? ");
        job1._endYear = double.Parse(Console.ReadLine());

        Console.Write("What is the name of the second company you worked in? ");
        job2._companyName = Console.ReadLine();
        Console.Write("What was your role in this company? ");
        job2._jobTitle = Console.ReadLine();
        Console.Write("What was the year you started working here? ");
        job2._startYear = double.Parse(Console.ReadLine());
        Console.Write("What was the year you stopped working here? ");
        job2._endYear = double.Parse(Console.ReadLine());

        Resume resume = new Resume(); //Created th e Resume class object as resume.
        Console.Write("Please enter your name! ");
        resume._personalName = Console.ReadLine();
        resume._job.Add(job1);
        resume._job.Add(job2);

        resume.DisplayResume(); //Called the DisplayResume() metthod.
    }
}