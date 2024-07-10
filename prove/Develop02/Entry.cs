public class Entry 
{
    public DateTime _date;
    public string _promptText;
    public string entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} -- Prompt: {_promptText}");
        Console.WriteLine($"Entry: {entryText}");
        Console.WriteLine("");
    }
}