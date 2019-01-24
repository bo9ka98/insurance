using System;
using Model.entity;

namespace Model.service
{
    public class UserControlService
    {
        private User authorizedUser;

        public User GetAuthoriaedUser()
        {
            return authorizedUser;
        }

        public User ReviewUserDataGAG(ControlUser controlUser)
        {
            User user = new User(new AliasMan("Ivanov", "Ivan", "Ivanovich"), controlUser);
            authorizedUser = user;
            return user;
        }
    }
}
