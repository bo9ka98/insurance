using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    public class ControlUser
    {
        public string Login{ get; set; }
        public string Password { get; set; }
        public readonly bool superuser;

        public ControlUser(string loginUser, string passwordUser, bool superuserFlag)
        {
            Login = loginUser;
            Password = passwordUser;
            superuser = superuserFlag;
        }
    }
}
