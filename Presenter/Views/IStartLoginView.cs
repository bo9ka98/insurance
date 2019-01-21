using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IStartLoginView : IView
    {
        event Delegates.VerificationUser VerificationUser;
        void ShowError(string massage);
    }
}
