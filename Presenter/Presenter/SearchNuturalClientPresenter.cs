using Ninject;
using Presenter.View;

namespace Presenter.Presenter
{
    class SearchNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchNuturalClientView _view;


        public SearchNuturalClientPresenter(IKernel kernel, ISearchNuturalClientView view)
        {
            _kernel = kernel;
            _view = view;

            //_view.EnterLogin += () => null;
        }

        private void EnterSearch()
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
