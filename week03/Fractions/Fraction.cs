using System;

public class Fraction
{
    private int _top, _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fracText = ($"{_top}/{_bottom}");
        return fracText;
    }

    public double GetDecimalValue()
    {   
        return (double)_top/(double)_bottom;
    }
}

// I dont know if i'm supposed to just print the fraction to the screen or assign it to a variable. 
// Do i only print them through the Gets? What do I do with the Set method?