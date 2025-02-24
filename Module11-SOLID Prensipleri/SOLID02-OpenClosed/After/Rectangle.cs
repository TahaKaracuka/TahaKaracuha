using System;

namespace SOLID02_OpenClosedRepsonsibility.After;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
