using System;

public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        _text = text;
        _IsHidden = false; // Default to not hidden
    }

    public void Hide()
    {
        _IsHidden = true;
    }
    public void Show()
    {
        _IsHidden = false;
    }
    public bool IsHidden()
    {
        return _IsHidden;
    }
    public string GetDisplayText()
    {
        if (_IsHidden)
        {
            return new string('_', _text.Length); // Return underscores for hidden words
        }
        return _text; // Return the actual word if not hidden
    }
}