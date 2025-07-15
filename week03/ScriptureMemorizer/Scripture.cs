public class Scripture
{
    private string _scriptureNumber;
    private string _scriptureQuote;



    public Scripture()
    {

    }

    public string GetScriptureNumber()
    {
        SetScriptureNumber();
        return _scriptureNumber;
    }

    Reference refere1 = new Reference();
    public void SetScriptureNumber()
    {
        _scriptureNumber = refere1.GetReference();
    }


    public string GetScriptureQuote()
    {
        SetScriptureQuote();
        return _scriptureQuote;
    }

    public void SetScriptureQuote()
    {
        string number = GetScriptureNumber();

        if (number == "Alma 2:33")
        {
            _scriptureQuote = "But Alma, with his guards, contended with the guards of the king of the Lamanites until he slew and drove them back.";
        }

        else if (number == "John 15:4")
        {
            _scriptureQuote = "Abide in me, and I in you.As the branch cannot bear fruit of itself, except it abide in the vine; no more can ye, except ye abide in me.";
        }

        else if (number == "2Nephi 2:2")
        {
            _scriptureQuote = "Nevertherless, Jacob, my firstborn in the wilderness, thou knowest the greatness of God, and he shall consecrate thine affliction for thy gain.";
        }

        else if (number == "1Cor 15:29")
        {
            _scriptureQuote = "Else what shall they do which are baptized for the dead, if the dead rise not at all? Why are they then baptized for the dead?";
        }
        else
        {
            _scriptureQuote = "And thus he was baptized, and the Spirit of God descended upon him, and thus he was born of the Spirit, and became quickened in the inner man.";
        }

        Console.WriteLine($"{_scriptureNumber}; {_scriptureQuote}");
    }


    public void DisplayScriptureQuote()
    {
        string quote = GetScriptureQuote();
    }

}