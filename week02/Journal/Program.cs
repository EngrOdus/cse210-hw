using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal1 = new Journal();
        int menu = 0;
        while (menu != 5)
        {
        
            Console.WriteLine("Enter a MENU number and hit Enter button:");
            Console.WriteLine("To Write: press 1");
            Console.WriteLine("To Display: press 2");
            Console.WriteLine("To Save: press 3");
            Console.WriteLine("To Load: press 4");
            Console.WriteLine("To Quit: press 5");
            Console.Write("What do you want to do? ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                PromptGenenrator genenrator = new PromptGenenrator();
                Entry entry1 = new Entry();

                entry1._promptText = genenrator.GetRandomPrompt();
                entry1._entryText = Console.ReadLine();
                DateTime currentDateTime1 = DateTime.Now;
                entry1._date = currentDateTime1.ToShortDateString();
                journal1.AddEntry(entry1);
            }

            else if (menu == 2)
            {

                journal1.DisplayAll();
            }

            else if (menu == 3)
            {

                Console.Write("Enter file name. ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(journal1._entry);
                }


            }

            else if (menu == 4)
            {
                
            }

            else if (menu == 5)
            {
                break;
            }

        }
       
    }
}