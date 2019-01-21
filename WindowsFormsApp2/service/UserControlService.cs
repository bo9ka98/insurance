using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
