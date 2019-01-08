using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IStartLoginView : IView
    {
        string LoginString { get; }
        string PassString { get; }
        bool SuperuserFlag { get; }
        event Action EnterLogin;
        void ShowError(string massage);
    }
}
