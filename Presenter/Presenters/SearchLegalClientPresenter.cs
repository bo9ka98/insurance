using System;
using Ninject;

namespace Presenter
{
    public class SearchLegalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchLegalClientView _view;

        public SearchLegalClientPresenter(IKernel kernel, ISearchLegalClientView view)
        {
            _kernel = kernel;
            _view = view;

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
