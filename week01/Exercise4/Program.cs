using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Working with a List Project.");

        List<int> number = new List<int>();

        float total = 0;
        float average = 0;
        float largest = 0;
        float numberCount = 0;


        int yourNumber = 1;
        while (yourNumber != 0)
        {
            Console.Write("Enter a list of numbers and type 0 when finished. ");
            yourNumber = int.Parse(Console.ReadLine());

            if (yourNumber > 0)
            {
                number.Add(yourNumber);
            }
        }

        foreach (int item in number)
        {
            total += item;
            numberCount += 1;
            if (item > largest)
            {
                largest = item;
            }
            Console.WriteLine(item);
        }
        average = total / numberCount;
        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The aversge is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}