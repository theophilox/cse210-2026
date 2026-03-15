public class Entry
{

    public string _date;
    public string _answer;

    public void WriteEntry()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToString();


        Console.WriteLine("Write you message below:");
        Console.Write("Start Here ~> ");
        _answer = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"{_date} - {_answer}");
        Console.WriteLine("---------------------------------------------------");
    }
}