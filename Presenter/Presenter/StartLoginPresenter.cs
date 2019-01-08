using System;
using Ninject;

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

            _view.EnterLogin += () => EnterLogin(_view.LoginString, _view.PassString, _view.SuperuserFlag);
        }

        private void EnterLogin(string loginStr, string passStr, bool superuserFlag)
        {
            _kernel.Get<WorkMenuPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
