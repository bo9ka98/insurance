using System;
using Model.entity;

namespace Presenter
{
    public interface IVisualizeNuturalClientView : IView, IHomeButton
    {
        event Action saveData;
        void SetIndividClientData(IndividClient nuturalClient);
    }
}
