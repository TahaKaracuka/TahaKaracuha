using System;

namespace SOLID05_DependecyInvertion.Before;

public class UserManager
{
    private EmailNotifier _emailNotifier = new EmailNotifier();
    public void Register(string userName)
    {
        //User Register kodları
        _emailNotifier.SendEmail("Merhaba " + userName);
    }
}
