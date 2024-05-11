using System;
class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {   
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        do
        {
            var random = new Random();
            int index = random.Next(_words.Count);

            if (_words[index].GetIsHidden() != true)
            {
                _words[index].Hide();
                count ++;
            }

            int countBool = 0;
            foreach (Word word in _words)
            {
                if (word.GetIsHidden() != false)
                {
                    countBool ++;
                }
            }

            if (countBool > _words.Count() - 1)
            {
                count ++;
            }
        }
        while (count < numberToHide);
    }

    public string GetDisplayText()
    {   
        string text = "";
        foreach (Word word in _words)
        {   
            text += word.GetDisplayText() + " ";
        }

        string scripture = _reference.GetDisplayText() + " " + text;
        return scripture;
    }

    public bool IsCompletelyHidden()
    {       
        int count = 0;
        bool check = false;
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() != false)
            {
                count ++;
            }
        }
        if (count >= _words.Count())
        {
            check = true;
        }
        return check;
    }
}