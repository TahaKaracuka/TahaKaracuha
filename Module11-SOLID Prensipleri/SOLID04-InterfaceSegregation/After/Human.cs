using System;

namespace SOLID04_InterfaceSegregation.After;

public class Human : IWorkable, IEatable, ISleepable
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
