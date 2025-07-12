public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1; // initializes the class attribute "_top" of the fraction1 object to 1.
        _bottom = 1; // initializes the class attribute "_bottom" of the fraction1 object to 1.
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber; // Store the wholeNumber value from fraction2 object into the class attribute "_top" of the fraction2 object
        _bottom = 1; // initializes the class attribute "_bottom" of the fraction2 object to 1.
    }

    public Fraction(int top, int bottom)
    {
        _top = top; // Store the top value from the fraction3 & fraction4 objects into the class attribute "_top" of the fraction3 & fraction4 objects.
        _bottom = bottom; // Store the bottom value from the fraction3 & fraction4 objects into the class attribute "_bottom" of the fraction3 and fraction4 objects.
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public string GetFractionString(string top, string bottom)
    {
        top = GetTop().ToString();// Convert to string
        bottom = GetBottom().ToString();//Convert to string.
        return top + "/" + bottom;//Returned the string representation.
    }

    public Decimal GetDecimalValues(int topValue, int bottomValue)
    {
        topValue = _top;
        bottomValue = _bottom;
        Decimal result = Decimal.Divide(topValue, bottomValue); // converted from int to decimal points value using C#.
        return result; //Return the decimal value.
    }
}