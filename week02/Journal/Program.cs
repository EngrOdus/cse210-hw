using System;
using System.IO;
// In order to exceed core requirements, I developed Greeting.cs class that get 
//the hour of the day and print a welcome message specific to the 
//current hour of the day.
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");
        Greeting greet = new Greeting();
        greet.GreetingTime();


        Journal journal1 = new Journal(); //Create the Journal class object.
        int menu = 0; // Initialize menu to zero.
        while (menu != 5) // create a menu comparism loop.
        {

            Console.WriteLine("Enter a MENU number and hit Enter button:");
            Console.WriteLine("To Write: press 1");
            Console.WriteLine("To Display: press 2");
            Console.WriteLine("To Save: press 3");
            Console.WriteLine("To Load: press 4");
            Console.WriteLine("To Quit: press 5");
            Console.Write("What do you want to do? "); // Take Menu input from the user
            menu = Convert.ToInt32(Console.ReadLine()); // Re-assign the user input to the menu variable.
            string fileName;


            if (menu == 1)
            {
                PromptGenenrator genenrator = new PromptGenenrator(); //Create the PromptGenertor class object.
                Entry entry1 = new Entry(); // Create th Entry class object

                entry1._promptText = genenrator.GetRandomPrompt();// Get random question from the GetRandomPrompt method and store it in the _promptText attribute in the Entry class.
                entry1._entryText = Console.ReadLine(); // Store the user response in the _entryText attribute in the Entry class.
                DateTime currentDateTime1 = DateTime.Now; // Get the current date from the computer and store it in the currentDateTime1 variable.
                entry1._date = currentDateTime1.ToShortDateString(); // Re-assign the date to the _date attribute in the Entry class.
                journal1.AddEntry(entry1); // Calling the AddEntry() method from the Journal class, add all the entries to the Entry list including the date.
            }

            else if (menu == 2)
            {
                Console.WriteLine("List in journal is:");

                journal1.DisplayAll();
            }

            else if (menu == 3)
            {

                Console.Write("Enter file name. ");
                fileName = Console.ReadLine();
                {
                    journal1.SaveToFile(fileName);
                }


            }

            else if (menu == 4)

            {
                Console.Write("Enter the file name you want to load. ");
                fileName = Console.ReadLine();
                {
                    journal1.LoadFromFile(fileName);
                }

            }

            else if (menu == 5)
            {
                break;
            }

        }

    }
}