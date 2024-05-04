using System;
using System.IO; 
using System.Collections.Generic;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {   
        _entries.Add(newEntry);
        Console.WriteLine();
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {   
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveFile(string filename)
    {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
    }

    public void LoadFromFile(string filename)
    {   
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
        Console.WriteLine();
    }

    public void ShowInfo() //Exceeding the Requirements
    {
        List<string> dates = new List<string>();

        int count = 0;

        foreach (Entry entry in _entries)
        {
            if (!dates.Contains(entry._date))
            {
                dates.Add(entry._date);
                count ++;
            }
        }
        Console.WriteLine($"There are {count} days registred");
        Console.WriteLine();
    }
}
