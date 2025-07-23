using System.ComponentModel.DataAnnotations;

public class Reference
{
    private string _scriptureReference;
    //private List<string> _reference = new List<string>();

    private string[] _reference = { "Alma 2:33", "John 15:4", "2Nephi 2:2", "1Cor 15:29", "Moses 6: 65" };


    public Reference()
    {

    }

    public void SetReference()
    {
        _scriptureReference = GetRandomReference();
    }
  
    public string GetReference()
    {
        SetReference();
        return _scriptureReference;
    }

    public string GetRandomReference()
    {

        Random randomReference = new Random();

        string rand = _reference[randomReference.Next(0, _reference.Length)];

        return rand;
    }
}