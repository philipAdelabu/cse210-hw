using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

         activities.Add(new Running("Running", 3, 400));
         activities.Add(new Cycling("Cycling", 4, 900));
         activities.Add(new Swimming("Swimming", 5, 540));

         foreach(Activity activity in activities)
              Console.WriteLine(activity.GetSummary());
    }
}