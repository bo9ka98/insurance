
using Model.entity;

namespace Model.service
{
    internal interface IUserControlService
    {

        User RegistrUser(ControlUser controlUser);
        bool RegistrNewUser(User user);
    }
}
