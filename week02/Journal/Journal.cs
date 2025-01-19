using System.IO;
using System;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        foreach (Entry entry in _entries)
        {
            using (StreamWriter outputFile = new StreamWriter(filename, append:true))
            {
                // Turning the entry attributes into strings
                string date = entry._date;
                string promptText = entry._promptText;
                string entryText = entry._entryText;

                // You can use the $ and include variables just like with Console.WriteLine
                outputFile.WriteLine($"Date: {date}|Prompt Text: {promptText}|{entryText}|"); 
            }
        }
        // Message to say that it was successfully saved :)
        Console.WriteLine($"Your Journal was saved successfully in {filename}");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] entries = line.Split("|");

            string date = entries[0];
            string promptText = entries[1];
            string entryText = entries[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;

            _entries.Add(entry);
        }

        // Successful message :)
        Console.WriteLine($"The file {filename} was successfully loaded.");
    }
}