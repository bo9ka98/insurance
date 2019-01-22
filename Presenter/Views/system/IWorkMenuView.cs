using System;
using Model;

namespace Presenter
{
    public interface IWorkMenuView: IView
    {
        // {readonli} for sellect client type
        string ClientStr { get; } 
        string FisClientStr { get; }
        string JurClientStr { get; }

        string SelectionClientTipeStr { get; }
        void SetUserDataView(User user);
        event Action EnterButtonNext;
        event Action EnterButtonLogOut;


    }
}
