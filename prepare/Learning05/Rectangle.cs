using System;

class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle (string color, double length, double widht) : base (color)
    {
        _length = length;
        _width = widht;
    }

    public override double GetArea()
    {
        return _width * _length;
    } 
}