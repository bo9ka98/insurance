using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
    public interface IVisualizeNuturalClientView : IView, IHomeButton
    {
        event Delegates.TransmitDataOfCreatAtVisualizeNuturalClient ViewData;

        void SetManData(Man man);
    }
}
