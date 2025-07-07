public class Entry
{
    //Create attributes //
    public string _date;
    public string _promptText;
    public string _entryText;

    //Create the Entry class constructor //
    public Entry()
    {

    }
    //Create method //
    public void Display()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_promptText}, Entry: {_entryText}");
    }   
}