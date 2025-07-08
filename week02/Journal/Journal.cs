public class Journal
{
    //Create attributes
    public List<Entry> _entry = new List<Entry>();


    //create the Journal class constructor //
    public Journal()
    {

    }
    //Create Methods. //
    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);
        //Console.WriteLine(_entry);
    }
    public void DisplayAll()
    {
        Console.WriteLine("List in journal is:");
        foreach (Entry n in _entry)
        {
            Console.WriteLine($"Prompt Question: {n._promptText}, Response: {n._entryText}, Date: {n._date}");
        }
    }
    public void SaveToFile(string fileName)
    {
        
    }
    public void LoadFromFile(string fileName)
    {
        
    }
}