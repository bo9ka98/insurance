using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ICreatLegalClientView: IView , IHomeButton
    {
        event Action EnterSearch;
    }
}
