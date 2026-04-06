public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This practice helps you calm down by guiding you through gentle, slow breaths. Clear your thoughts and center your attention on each inhale and exhale.");
        SetDuration(30);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayReady();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(6);
            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

}