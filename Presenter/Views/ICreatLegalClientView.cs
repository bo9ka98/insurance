using Model;

namespace Presenter
{
    public interface ICreatLegalClientView: IView , IHomeButton
    {
        event Delegates.TransmitDataOfCreatAtVisualizeLegalClient TransmitDataOfCreatAtVisualizeLegalClient;

        void setAliasCompanu(AliasCompanu aliasCompanu);
    }
}
