public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Add code here
    }

    public void SaveToFile(string[] file)
    {
        // Add code here
    }

    public void LoadFromFile(string[] file)
    {
        // Add code here
    }
}