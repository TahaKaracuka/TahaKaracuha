using System;

namespace SOLID05_DependecyInvertion.After;

public class UserManager
{
    private INotifier _notifier;

    public UserManager(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Register(string userName)
    {
        _notifier.SendNotification("Hoş geldiniz " + userName);
    }
}
