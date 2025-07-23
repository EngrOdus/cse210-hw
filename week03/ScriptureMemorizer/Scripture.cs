public class Scripture
{
    private string _scriptureNumber;
    private string _scriptureQuote;
    private List<string> _words;



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
        _words = _scriptureQuote.Split(" ").ToList();
        return _scriptureQuote;
        
    }

    public string SetScriptureQuote()
    {
        string number = GetScriptureNumber();

        if (number == "Alma 2:33")
        {
            _scriptureQuote = "But Alma with his guards contended with the guards of the king of the Lamanites until he slew and drove them back.";
        }

        else if (number == "John 15:4")
        {
            _scriptureQuote = "Abide in me and I in you. As the branch cannot bear fruit of itself, except it abide in the vine; no more can ye, except ye abide in me.";
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
        return _scriptureQuote;

    }
    

    public string click;
    public void HideRandomWords()
    {
        int indexesToHide;

        string quote = GetScriptureQuote();

        //This display method will randomly

        while (click != "quit")

        {
            Console.Write("Do you want to guess? ");
            click = Console.ReadLine();
            if (click != "quit")
            {
                int counter = 0;
                HashSet<int> indexeHidden = new HashSet<int>();
                Random random = new Random();

                while (indexeHidden.Count < _words.Count)
                {

                    Console.Write("Press the ENTER button to hide words. ");
                    click = Console.ReadLine();


                    do
                    {
                        indexesToHide = random.Next(_words.Count);
                    }
                    while (indexeHidden.Contains(indexesToHide));
                    indexeHidden.Add(indexesToHide);
                    counter += 1;
                    Console.WriteLine(indexeHidden);
                    if (click == "quit")
                    {
                        click = "quit";
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < _words.Count; i++)
                        {
                            if (indexeHidden.Contains(i))
                            {
                                
                                Console.WriteLine(indexeHidden);
                                //Console.Write("__");
                            }
                        }
                    }
                }
            }

        }
        
    }

}