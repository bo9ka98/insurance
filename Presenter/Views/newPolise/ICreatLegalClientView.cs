using Model;

namespace Presenter
{
    public interface ICreatLegalClientView: IView , IHomeButton
    {
        event Delegates.TransmitDataLegalCatV TransmitDataLegalCatV;

        void setAliasCompanu(AliasCompanu aliasCompanu);
    }
}
