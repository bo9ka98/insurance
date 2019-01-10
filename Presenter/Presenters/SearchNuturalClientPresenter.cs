using Ninject;

namespace Presenter
{
    public class SearchNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchNuturalClientView _view;


        public SearchNuturalClientPresenter(IKernel kernel, ISearchNuturalClientView view)
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
