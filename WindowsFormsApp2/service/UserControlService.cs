using System;
using Model.entity;

namespace Model.service
{
    public class UserControlService : IUserControlService
    {
        private User authorizedUser;

        public User GetAuthoriaedUser()
        {
            return authorizedUser;
        }

        public User RegistrUser(ControlUser controlUser)
        {
            // ходит в ДАО и проверяет юзера в ДБ
            User user = new User(new AliasMan("Ivanov", "Ivan", "Ivanovich"), controlUser);
            authorizedUser = user;
            return user;
        }

        public bool RegistrNewUser(User user)
        {
            throw new NotImplementedException();
        }


    }
}
