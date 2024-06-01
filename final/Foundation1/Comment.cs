using System;

class Comment
{
    public string _person;

    public string _text;

    public void DisplayComments()
    {          
        Console.WriteLine($"> {_person}: {_text}");   
    }
}