using Ninject;
using System;


namespace Presenter
{
    public class CreatLegalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICreatLegalClientView _view;


        public CreatLegalClientPresenter(IKernel kernel, ICreatLegalClientView view)
        {
            _kernel = kernel;
            _view = view;

            //_view.EnterLogin += () => null;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
