using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software";
        job1._endYear = "2023";
        job1._startYear = "1990"; 
        job1.Display();
    }
}
