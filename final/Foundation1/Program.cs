using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Video 1
        Video v1 = new Video();
        v1._title = "How To Close A Door";
        v1._author = "James White";
        v1._length = 30;

        Comment c1 = new Comment();
        c1._person = "John";
        c1._text = "Nice video";

        Comment c2 = new Comment();
        c2._person = "Bill";
        c2._text = "Very easy to understand, congrats!";

        Comment c3 = new Comment();
        c3._person = "Andrew";
        c3._text = "When will the 'how to open a door video release?' I'm stuck!";

        v1.AddEntry(c1);
        v1.AddEntry(c2);
        v1.AddEntry(c3);
        
        // Video 2
        Video v2 = new Video();
        v2._title = "How To Cook Pasta";
        v2._author = "Italian Chef";
        v2._length = 1200;

        Comment c4 = new Comment();
        c4._person = "Olivia";
        c4._text = "I made it, and it's delicious!";

        Comment c5 = new Comment();
        c5._person = "Jessica";
        c5._text = "You're truly a Chef";

        Comment c6 = new Comment();
        c6._person = "Antony";
        c6._text = "Can you make a video of 'how to boil water' please? ";

        v2.AddEntry(c4);
        v2.AddEntry(c5);
        v2.AddEntry(c6);
        
        // Video 3
        Video v3 = new Video();
        v3._title = "The Book of Mormon Explained in Less Than a Minute";
        v3._author = "Moroni";
        v3._length = 59;

        Comment c7 = new Comment();
        c7._person = "Jacke";
        c7._text = "Interesting, I might read it.";

        Comment c8 = new Comment();
        c8._person = "Arianna";
        c8._text = "I love the Book of Mormon, it changed my life!";

        Comment c9 = new Comment();
        c9._person = "Paul";
        c9._text = "Wasn't it about Mormon?";

        v3.AddEntry(c7);
        v3.AddEntry(c8);
        v3.AddEntry(c9);

        // Displays
        v1.DisplayVideoInfo(1);
        v2.DisplayVideoInfo(2);
        v3.DisplayVideoInfo(3);
    }
}