using System;

namespace SOLID03_LiskovsSubstitiuon.Before;

public class Square : Rectangle
{
    public override double Width { set => base.Width = base.Height = value; }
    public override double Height { set => base.Width = base.Height = value; }
}
