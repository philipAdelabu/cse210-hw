using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job._jobTitle = "Software";
        job._endYear = "2023";
        job._startYear = "1990"; 
        job.Display();

        Resume resume = new Resume();
        resume._name = "Jonh Doe";
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Engineer";
        job1._startYear = "2001";
        job1._endYear = "2020";
        resume._jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "Stripe";
        job2._jobTitle = "Software Developer";
        job2._startYear = "2012";
        job2._endYear = "2021";
        resume._jobs.Add(job2);

        resume.Display();
    }
}
