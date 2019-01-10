﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ISearchLegalClientView : IView, IHomeButton
    {
        event Action EnterSearch;

        string OrganisationNameLegalClientStr { get; }
        string UTNLegalClientStr { get; }
    }
}
