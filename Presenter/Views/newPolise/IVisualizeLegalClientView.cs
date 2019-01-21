using System;
using Model;

namespace Presenter
{
    public interface IVisualizeLegalClientView : IView, IHomeButton
    {
        void SetLegalClientData(LegalСlient legalClient);
    }
}
