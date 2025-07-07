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
        Console.WriteLine(_entry);
    }
    public void DisplayAll()
    {
        Console.WriteLine(_entry);
    }
    public void SaveToFile(string fileName)
    {
        
    }
    public void LoadFromFile(string fileName)
    {
        
    }
}