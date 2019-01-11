using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ICreatNuturalClienView : IView , IHomeButton
    {
        event Delegates.TransmitDataOfCreatAtVisualizeNuturalClient ViewDataMan;

        void setAliasMan (string surname, string name, string middlename);

    }
}
