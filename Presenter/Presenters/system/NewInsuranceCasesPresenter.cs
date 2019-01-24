using Ninject;
using System;
using Presenter.Views;
using Model.entity;
using Model.service;

namespace Presenter.Presenters
{
    public class NewInsuranceCasesPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly INewInsuranceCasesView _view;

        public NewInsuranceCasesPresenter(IKernel kernel, INewInsuranceCasesView view)
        {
            _kernel = kernel;
            _view = view;

            _view.RegistrInsuranceCases += RegistrInsuranceCases;
        }

        public void RegistrInsuranceCases(InsuranceCases insuranceCases)
        {
            User user = _kernel.Get<UserControlService>().GetAuthoriaedUser();
            _kernel.Get<WorkMenuPresenter>().Run(user);
            _view.Close();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
