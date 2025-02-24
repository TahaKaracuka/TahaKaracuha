using System;

namespace SOLID02_OpenClosedRepsonsibility.Before;

public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        else if (shape is Triangle triangle)
        {
            return triangle.Base * triangle.Height / 2;
        }
        throw new ArgumentException("Desteklenmeyen tip");
    }
}
