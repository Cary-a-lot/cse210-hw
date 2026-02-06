// Fraction.cs
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constrctor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Oneparameter const
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Twoparameter const
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Get and set
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

    // Returning fractions now that its a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // and now finally decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
