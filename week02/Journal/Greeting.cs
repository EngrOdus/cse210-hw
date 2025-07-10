public class Greeting
{

    public Greeting()
    {

    }

    public void GreetingTime()
    {
        DateTime currentHour = DateTime.Now;
        int hour = currentHour.Hour;

        if (hour < 12)
        {
            Console.WriteLine("Good Morning, You're Welcome To The Journal App!");
        }


        else if (hour < 17)
        {
            Console.WriteLine("Good afternoon, you are welcome To The Journal App!");
        }


        else if (hour < 19)
        {
            Console.WriteLine("Good Evening, You're Welcome To The Journal App!");
        }

        
        else
        {
            Console.WriteLine("It is Night. Please Record Your Journal If You Can.");
        }
    
    }
}