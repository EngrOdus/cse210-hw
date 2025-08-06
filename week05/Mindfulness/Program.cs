using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.Write("Enter countdown time in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int totalSeconds) && totalSeconds > 0)
        {
            Console.WriteLine("Breath in...\n");

            for (int i = totalSeconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Time left: {i} second{(i != 1 ? "s" : "")}");
                Thread.Sleep(3000); // Pause for 3 second
            }

            Console.Clear();
            Console.WriteLine("⏰ Time's up! \n Breath Out!");
            Thread.Sleep(3000); // Pause for 3 second
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    


    }
}