using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {   
        string newText = "";
        if (_isHidden == true)
        {   
            foreach (char c in _text)
            {
                newText += "_";
            }
            _text = _text.Replace(_text, newText);
        }
        return _text;
    }
}