using System;
using Model.entity;

namespace Presenter
{
    public interface INewPoliceCategoriView : IView
    {
        event Delegates.RegistrPoliceCategori RegistrPoliceCategori;
    }
}
