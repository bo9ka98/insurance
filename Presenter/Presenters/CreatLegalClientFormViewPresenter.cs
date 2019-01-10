using Ninject;
using System;


namespace Presenter
{
    class CreatLegalClientFormViewPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchNuturalClientView _view;


        public CreatLegalClientFormViewPresenter(IKernel kernel, ISearchNuturalClientView view)
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
