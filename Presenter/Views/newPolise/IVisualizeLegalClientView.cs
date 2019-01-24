using System;
using Model.entity;

namespace Presenter
{
    public interface IVisualizeLegalClientView : IView, IHomeButton
    {
        void SetLegalClientData(LegalСlient legalClient);
    }
}
