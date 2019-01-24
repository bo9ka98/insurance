using System;
using Ninject;
using Model.entity;
using Model.service;

namespace Presenter
{
    public class StartLoginPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStartLoginView _view;


        public StartLoginPresenter(IKernel kernel, IStartLoginView view)
        {
            _kernel = kernel;
            _view = view;

            _view.VerificationUser += VerificationUser;
        }

        private void VerificationUser(ControlUser controlUser)
        {
            User user = _kernel.Get<UserControlService>().ReviewUserDataGAG(controlUser);
            if (user != null)
            {
                _kernel.Get<WorkMenuPresenter>().Run(user);
            }
            else
            {
                //ошибку выведи
            }
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
