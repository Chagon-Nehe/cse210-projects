public class Fractions
{
    private int _Top;
    private int _Bottom;



    public Fractions()
    {
        _Top = 1; // Default to 1 for numerator
        _Bottom = 1; // Default to 1 to avoid division by zero
    }
    public Fractions(int top)
    {
        _Top = top;
        _Bottom = 1; // Default to 1 to avoid division by zero
    }
    public Fractions(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Bottom cannot be zero.");
        }
        _Top = top;
        _Bottom = bottom;
    }

    public int GetTop()
    {
        return _Top;
    }
    public void SetTop(int top)
    {
        _Top = top;
    }
    public int GetBottom()
    {
        return _Bottom;
    }
    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Bottom cannot be zero.");
        }
        _Bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_Top}/{_Bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_Top / _Bottom;
    }
}