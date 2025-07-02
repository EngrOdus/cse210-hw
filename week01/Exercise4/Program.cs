using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Working with a List Project.");

        List<int> number = new List<int>();

        int yourNumber = 1;
        while (yourNumber != 0)
        {
            Console.Write("Enter a list of numbers and type 0 when finished. ");
            yourNumber = int.Parse(Console.ReadLine());
             number.Add(yourNumber);
        }
    }
}