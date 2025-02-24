using System;

namespace SOLID04_InterfaceSegregation.Before;

public class Human : IWorker
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
