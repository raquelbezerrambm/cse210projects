using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors:
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

    // Getters and setters
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

    // Methods to return the representations of fractionary and decimal visualizations
    public string GetFractionString()
    {
        string topString = _top.ToString();
        string bottomString = _bottom.ToString();
        string fractionString = $"{topString}/{bottomString}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top/(double)_bottom;
        return decimalValue;
    }
}