public class Journal
{
    //Create attributes
    public List<Entry> _entry = new List<Entry>();


    //create the Journal class constructor //
    public Journal()
    {

    }

    
    //Create the AddEntry() Methods. //
    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);
    }
    

    //created the DisplayAll() method.
    public void DisplayAll()
    {
        foreach (Entry n in _entry)
        {
            Console.WriteLine($"Prompt Question: {n._promptText}, Response: {n._entryText}, Date: {n._date}");
        }
    }


    public void SaveToFile(string fileName)
    {
        //string dirPath = @".";
        //string fullPath = dirPath + fileName;
        using (StreamWriter writer = new StreamWriter(fileName))
        {

            foreach (Entry n in _entry)
            {
                string allItems;
                allItems = $"Prompt Question: {n._promptText}, Response: {n._entryText}, Date: {n._date}";
                writer.WriteLine(allItems);
            }
        }
    }


    public void LoadFromFile(string fileName)
    {
        string readText = File.ReadAllText(fileName);
        Console.WriteLine(readText);
    }
}