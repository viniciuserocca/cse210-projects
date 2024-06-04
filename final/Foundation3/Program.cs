using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Event
        Address a1 = new Address("3239 Highland View Drive", "Sacramento", "CA", "USA");
        Lecture l = new Lecture("Mark", 100, "Data Analysis Camp", "Data Base Course", "09/07/2024", "08:00am", a1);

        //Reception Event
        Address a2 = new Address("123 Curzon St", "London", "England", "UK");
        Reception r = new Reception("reception@gmail.com", "Wedding", "John & Carol's Wedding", "17/12/2024", "08:00pm", a2);

        //Outdoor Event
        Address a3 = new Address("World Dr", "Orlando", "FL", "USA");
        Outdoor o = new Outdoor("Sunny", "Walt Disney World Resort", "Trip to Disney World", "05/10/2024", "10:00am", a3);

        //Displays
        Console.Clear();

        l.GetStandardDetails();
        l.GetFullDetails();
        l.ShortDescription();

        r.GetStandardDetails();
        r.GetFullDetails();
        r.ShortDescription();

        o.GetStandardDetails();
        o.GetFullDetails();
        o.ShortDescription();
    }
}