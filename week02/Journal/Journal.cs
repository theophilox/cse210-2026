using System;

public class Journal
{
    List<Entry> _journal = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _journal.Add(newEntry);
    }

    
    public void DisplayJournal()

    {
        foreach (Entry e in _journal)
        {
            e.DisplayEntry();
        }
    }

     public void SaveJournal(string fileName)
    {
        Console.Write("Saving....");


        string path = Path.Combine("..", "..", "..", fileName);

        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (Entry entry in _journal)
            {
                writer.WriteLine($"{entry._date}");
                writer.WriteLine($"{entry._prompt}");
                writer.WriteLine($"{entry._answer}");
                writer.WriteLine("-------------------------------");
            }
        }

        Console.WriteLine("\nSaved successfully!");
    }

    public void LoadJournal(string fileName)
    
    {

        _journal.Clear();
        
        Console.WriteLine("Loading your journal...");

        string path = Path.Combine("..", "..", "..", fileName);

        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < lines.Length; i +=4) 
        {
            Entry newEntry = new Entry();

            newEntry._date = lines[i];
            newEntry._prompt = lines[i + 1];
            newEntry._answer = lines[i + 2];

            _journal.Add(newEntry);
        }
        Console.WriteLine("Your Journal has been retrieve.");

    }
}
