using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        string[] animals = { "cow", "goat", "pig", "birds", "dog", "antelope" };
        List<string> animalList = new List<string>();
        animalList.AddRange(animals);
        Console.Clear();
        foreach (string ani in animalList)
        {
            Console.WriteLine(ani);
        }

        for (int i = 0; i < animalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {animalList[i]}");

            List<string> names = new List<string>() { "<name>", "john", "paul", "tr", "df", "56" };
            Console.WriteLine(names.Count);
            Console.WriteLine(names.Count());
            foreach (var name in names)
            {
                Console.WriteLine(name.ToUpper());
            }

            names.ForEach(i => Console.WriteLine(i));
        }
    }
}