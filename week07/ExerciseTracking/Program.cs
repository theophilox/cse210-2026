using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();


        RunningActivity running = new RunningActivity("13 April 2026", 60, 6);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity("14 April 2026", 45, 15);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity("15 April 2026", 90, 30);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}