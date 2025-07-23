public class Word
{
    private string _word;
    private string _underscore = "_";
    public bool _isHidden;

    public Word()
    {

    }

    public void SetWordToHide()
    {
        //Scripture scriptureWord = new Scripture();
        //scriptureWord.HideRandomWords();
    }

    public string Hide()
    {
        Scripture scriptureWord = new Scripture();
        //This method will change the word(s) letters to underscore.
        scriptureWord.HideRandomWords();
        return _underscore;
    }
}