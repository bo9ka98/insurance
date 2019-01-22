using System;
using Model.entity;

namespace Model.service
{
    public class UserControlService
    {
        public User ReviewUserDataGAG(ControlUser controlUser)
        {
            User user = new User(new AliasMan("Ivanov", "Ivan", "Ivanovich"), controlUser);
            return user;
        }
    }
}
