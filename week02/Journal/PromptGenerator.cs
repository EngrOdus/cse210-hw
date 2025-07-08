public class PromptGenenrator
{
    //List<string> _prompt;

    public PromptGenenrator()
    {

    }

    public string GetRandomPrompt()
    {
        string _rand;

        Random randomGenerator = new Random(); //Created random object.

        int randomNumber = randomGenerator.Next(1, 6); //Declared the range to pick from and store in a variable randomNumber.
        if (randomNumber == 1)
        {
            Console.WriteLine(_rand = "What was your best experience today?");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine(_rand = "What one thing did you learn best today?");
        }
        else if (randomNumber == 3)
        {
            Console.WriteLine(_rand = "How best were you to your family today?");
        }
        else if (randomNumber == 4)
        {
            Console.WriteLine(_rand = "What do you love about your bet?");
        }
        else
        {
            Console.WriteLine(_rand = "What was your favorite task achieved today?");
        }
        return _rand;
    }
}
