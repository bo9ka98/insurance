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
        //event Delegates.TransmitDataOfCreatAtVisualizeNuturalClient ViewData;
        event Action saveData;
        void SetManData(IndividClient nuturalClient);
    }
}
