using System;
using Ninject;
using Model;

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
            // тут лежит куча логики
            _kernel.Get<WorkMenuPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
