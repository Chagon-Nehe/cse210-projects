public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = entry;
    }

    // This method abstracts the display logic.
    // The user just calls Display(), not worrying about Console.WriteLine specifics.
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    // This method abstracts the conversion of an Entry object into a saveable string format.
    // The specific delimiter ('|') and order are hidden from the caller.
    public string GetStringRepresentation()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
