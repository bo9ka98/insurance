﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Views
{
    public interface INewInsuranceCasesView : IView
    {
        event Delegates.RegistrInsuranceCases RegistrInsuranceCases;
    }
}
