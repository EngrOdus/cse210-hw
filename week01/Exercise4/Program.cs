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
        float lowest = 1000000000;


        int yourNumber = 1;
        while (yourNumber != 0)
        {
            Console.Write("Enter a list of positive and negative numbers and type 0 when finished. ");
            yourNumber = int.Parse(Console.ReadLine());

            if (yourNumber > 0)// determine where the user input stops.
            {
                number.Add(yourNumber);
            }
        }
        //loop to iterat through the list
        foreach (float item in number)
        {
            total += item;//update the sum of all numbers in the list.
            numberCount += 1; //stores the total numbers of items in the list.
            //Added if statement to get the largest number.
            if (item > largest)
            {
                largest = item;
            }
            //Added if statement to get the lowest positive number.
            if (item > 0 && item < lowest)
            {
                lowest = item;
            }
        }
        average = total / numberCount;
        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The aversge is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The lowest positive number is: {lowest}");

    }
}