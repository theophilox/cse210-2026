using System;
using System.ComponentModel;

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
}
