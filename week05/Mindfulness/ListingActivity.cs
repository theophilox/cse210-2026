public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    private List<string> _remainingPrompts;
    
    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This exercise encourages you to focus on the positive aspects of your life by listing as many things as you can in a specific area.");
        SetDuration(30);
        
        _prompts = new List<string> {
            "Which people in your life make you feel grateful or supported?",
            "What are some strengths or qualities in yourself that you’re proud of?",
            "Who have you made a positive impact on recently?",
            "When did you feel a sense of inspiration or guidance this month?",
            "Who are people you admire for their character or actions?"
            };
        _remainingPrompts = new List<string>(_prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Display as many responses you can to the following prompt:");
            Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
            Console.Write("\nYou may begin in...");
            ShowCountDown(5);
            Console.WriteLine();
            List<string> userResponses = new List<string>();
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                userResponses.Add(response);
                _count = userResponses.Count();
            }
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        return GetRandomItem(_prompts, _remainingPrompts);
    }

}