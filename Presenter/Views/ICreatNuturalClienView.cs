using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ICreatNuturalClienView : IView , IHomeButton
    {
        event Action EnterSearch;

        string SurnameNuturalClientStr { get; set; }
        string NameNuturalClientStr { get; set; }
        string MinnleNameNuturalClientStr { get; set; }
    }
}
