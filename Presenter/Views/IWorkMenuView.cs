using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IWorkMenuView: IView
    {
        // {readonli} for sellect client type
        string ClientStr { get; } 
        string FisClientStr { get; }
        string JurClientStr { get; }

        string SelectionClientTipeStr { get; }
        event Action EnterButtonNext;
        event Action EnterButtonLogOut;


    }
}
