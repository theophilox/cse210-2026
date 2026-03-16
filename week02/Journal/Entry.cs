public class Entry
{

    public string _date;
    public string _answer;

    public string _prompt;

    public void WriteEntry()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToString();


        Prompt prompt = new Prompt();
        string randomQuestion = prompt.GeneratePrompt();
        _prompt = randomQuestion;
        Console.WriteLine(_prompt);

        Console.Write("Answer Here ~~> ");
        _answer = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_answer}");
        Console.WriteLine("---------------------------------------------------");
    }
}