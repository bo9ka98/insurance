using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IWorkMenuView: IView
    {
        string SelectionTypeStr { get; }
        event Action EnterButtonNext;
        event Action EnterButtonLogOut;


    }
}
