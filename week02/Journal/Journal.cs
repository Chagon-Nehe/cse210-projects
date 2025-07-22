using System.IO;
public class Journal
{
    public List<Entry> _entries; // Internal data structure, hidden from direct external access

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Abstraction: Hides the direct manipulation of the internal _entries list.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Abstraction: Hides the iteration logic required to display each entry.
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Relies on Entry's own abstracted display
            Console.WriteLine(); // Add a blank line for readability
        }
    }

    // Abstraction: Hides all the file system operations for saving.
    // The user simply provides a filename.
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.GetStringRepresentation()); // Uses Entry's abstracted string representation
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Abstraction: Hides all the file system operations for loading and parsing.
    // The user simply provides a filename.
    public void LoadFromFile(string filename)
    {
        try
        {
            _entries.Clear(); // Clear existing entries before loading new ones
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    // Reconstruct Entry object from parsed parts
                    Entry loadedEntry = new Entry(parts[1], parts[2]);
                    loadedEntry._date = parts[0]; // Manually set the date from the file
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}