public class Person
{
    public string _givenName = "Odumamwen";
    public string _familyName = "Hemry";

    public Person()
    {

    }


    public void ShowEasternName()
    {
        Console.WriteLine($"Your name eastern name is {_familyName} {_givenName}.");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"Your western name is {_givenName} {_familyName}.");
    }
}