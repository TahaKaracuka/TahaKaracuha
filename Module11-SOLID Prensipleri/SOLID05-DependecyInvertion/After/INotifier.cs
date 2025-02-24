using System;

namespace SOLID05_DependecyInvertion.After;

public interface INotifier
{
    public void SendNotification(string message);
}
