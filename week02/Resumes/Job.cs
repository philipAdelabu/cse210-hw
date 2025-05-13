public class Job {
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string  _endYear;

    public void Display(){
     string message = _jobTitle + "  (" + _company + ") " + _startYear + "-" + _endYear; 
      Console.WriteLine(message);
      return;
    }
}