public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _remainingPrompts;

    private List<string> _remainingQuestions;

    public ReflectingActivity()
    {

        SetName("Reflection");
        SetDescription("This activity encourages you to reflect on moments when you demonstrated strength and resilience. It helps you recognize your inner power and see how you can apply it in other areas of your life.");

        SetDuration(30);

        _prompts = new List<string> {
            "Think about a time recently when you felt proud of yourself.",
            "Remember a moment when you made someones day better.",
            "Think of something new you tried that surprised you.",
            "Recall a time when you faced a challenge and kept going."
            };


        _questions = new List<string> {
            "What made this moment feel special?",
            "How did it make you feel at the time?",
            "Would you do anything differently now?",
            "What is one thing you learned about yourself?",
            "How did this experience affect others around you?",
            "What small detail do you remember most vividly?",
            "How could you use this moment to inspire yourself later?",
            "Why do you think this memory stuck with you?",
            "What is a positive takeaway you can carry forward?"
            };


        _remainingPrompts = new List<string>(_prompts);
        _remainingQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        string response = "";

        while (DateTime.Now < endTime && response == "")
        {
            DisplayPrompt();

            Console.WriteLine("When you have something in mind, press enter to continue.");
            response = Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            while (DateTime.Now < endTime)
            {
                DisplayQuestions();
            }

        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    // Generates a random prompt and ensures no duplicates
    {
        return GetRandomItem(_prompts, _remainingPrompts);
    }

    private string GetRandomQuestion()
    {
        if (_remainingQuestions.Count == 0)
        {
            _remainingQuestions = new List<string>(_questions);
        }

        int index = Random.Shared.Next(_remainingQuestions.Count);
        string question = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }
    private void DisplayQuestions()
    {

        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(7);

    }

}