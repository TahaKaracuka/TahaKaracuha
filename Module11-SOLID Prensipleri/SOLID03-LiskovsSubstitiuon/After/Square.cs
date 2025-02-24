using System;

namespace SOLID03_LiskovsSubstitiuon.After;

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}
