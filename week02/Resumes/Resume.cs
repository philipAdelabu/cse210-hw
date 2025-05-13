public class Resume{
    public string _name;
    public List<Job> jobs = new List<Job>();
    
    _name = "Joe Donw";
    jobs[0]._company = "Apple";
    jobs[0]._jobTitle = "Engineer";
    jobs[0]._startYear = "2001";
    jobs[0]._endYear = "2020";

    jobs[0]._company = "Stripe";
    jobs[0]._jobTitle = "Software Developer";
    jobs[0]._startYear = "2012";
    jobs[0]._endYear = "2021";


    public void Display(){
        Console.WriteLine(_name)
        foreach(Job job in Jobs){
            job.Display();
        }
    }
}