using System;
using Model;

namespace Presenter
{
    public interface IVisualizeLegalClientView : IView, IHomeButton
    {
        void setLegalClient(LegalСlient legalClient);
    }
}
