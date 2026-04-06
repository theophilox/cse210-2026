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

        int inhale;
        int exhale;

        if (GetDuration() < 12)
        {
            inhale = GetDuration() / 2;
            exhale = GetDuration() - inhale;
        }
        else
        {
            inhale = 6;
            exhale = 6;
        }

        

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(inhale);
            Console.Write("\nBreathe out...");
            ShowCountDown(exhale);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

}