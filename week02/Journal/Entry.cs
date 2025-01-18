public class Entry
{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}