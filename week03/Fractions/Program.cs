using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString("1", "1")); //Print the string representation.
        Console.WriteLine(fraction1.GetDecimalValues(1, 1)); //Print the decimal value.

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString("1", "1")); //Print the string representation.
        Console.WriteLine(fraction2.GetDecimalValues(1, 1)); //Print the decimal value.

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString("1", "1")); //Print the string representation.
        Console.WriteLine(fraction3.GetDecimalValues(1, 1)); //Print the decimal value.

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString("1", "1")); //Print the string representation.
        Console.WriteLine($"{fraction4.GetDecimalValues(1, 1)}"); //Print the decimal value.
    }
}