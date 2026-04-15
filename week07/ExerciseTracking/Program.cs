using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();


        RunningActivity running = new RunningActivity("03 Nov 2022", 30, 3);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity("03 Nov 2022", 30, 15);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity("03 Nov 2022", 30, 10);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}