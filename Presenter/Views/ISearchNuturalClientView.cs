﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ISearchNuturalClientView : IView , IHomeButton
    {
        event Action EnterSearch;

        string SurnameNuturalClientStr { get; }
        string NameNuturalClientStr { get; }
        string MinnleNameNuturalClientStr { get; }
    }
}
