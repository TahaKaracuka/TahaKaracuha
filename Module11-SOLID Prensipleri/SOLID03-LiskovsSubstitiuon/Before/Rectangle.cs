using System;

namespace SOLID03_LiskovsSubstitiuon.Before;

public class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }
    public double CalculateArea()
    {
        return Width * Height;
    }
}
