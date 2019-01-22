using System;
using Model.entity;

namespace Presenter
{
    public interface INewPoliceCategoriPresenterView : IView
    {
        event Delegates.RegistrPoliceCategori RegistrPoliceCategori;
    }
}
