using Model;

namespace Presenter
{
    public interface ICreatIndividClienView : IView , IHomeButton
    {
        event Delegates.TransmitDataIndividCatV ViewDataMan;

        void setAliasMan (AliasMan aliasMan);

    }
}
